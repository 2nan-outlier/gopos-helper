using GoposExcelToDbHelper.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.Utils
{
    public static class MybatisMapperMaker
    {
        public static string GetMapper(string table, List<ColumnInfo> cols)
        {
            var selectCols = string.Empty;
            var insertCols = string.Empty;
            var insertVals = string.Empty;
            var updateCols = string.Empty;
            var updateVals = string.Empty;
            var deleteVals = string.Empty;

            var maxColLength = cols.Max(x => x.name.Length) * 2 + 5;

            insertCols = string.Join(", ", cols.Select(x => x.name).ToList());
            foreach (ColumnInfo col in cols)
            {
                // ============================= select =============================
                var colString = $"{col.name} as {col.name.ToSnakeCase()}";
                colString += cols.IndexOf(col) == cols.Count - 1 ? string.Empty : ",";
                selectCols += $"\r\n      {colString.PadRight(maxColLength, ' ')}-- {col.comment}";
                // ==================================================================

                // ============================= insert =============================
                // insert, update, delete는 CREATED_AT, UPDATED_AT 사용 안함
                if (col.name.Equals("CREATED_AT") || col.name.Equals("UPDATED_AT")) continue;

                insertVals += $"\r\n      {col.name} = #{{{col.name.ToSnakeCase()}}}";
                insertVals += cols.IndexOf(col) == cols.Count - 1 ? string.Empty : ",";
                // ==================================================================

                // ============================= update =============================
                // update, delete는 CREATOR 사용 안함
                if (col.name.Equals("CREATOR")) continue;

                updateCols += $"\r\n      {col.name} = #{{{col.name.ToSnakeCase()}}}";
                updateCols += cols.IndexOf(col) == cols.Count - 1 ? string.Empty : ",";

                updateVals += cols.IndexOf(col) == 0 ? "\r\n      " : "\r\n      AND ";
                updateVals += $"{col.name} = #{{{col.name.ToSnakeCase()}}}";
                // ==================================================================

                // ============================= delete =============================
                // delete는 UPDATER 사용 안함
                if (col.name.Equals("UPDATER")) continue;

                deleteVals += cols.IndexOf(col) == 0 ? "\r\n      " : "\r\n      AND ";
                deleteVals += $"{col.name} = #{{{col.name.ToSnakeCase()}}}";
                // ==================================================================
            }

            var mapper = string.Empty;

            mapper += $"<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
            mapper += $"\r\n<!DOCTYPE mapper PUBLIC \" -//mybatis.org//DTD Mapper 3.0//EN\"";
            mapper += $"\r\n  \"http://mybatis.org/dtd/mybatis-3-mapper.dtd\">";
            mapper += $"\r\n<mapper namespace=\"gopos.master.dao.MasterDAO\">";
            mapper += $"\r\n";
            mapper += $"\r\n  <select id=\"{table.ToSnakeCase("get")}\" parameterType=\"HashMap\" resultType=\"LinkedHashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    SELECT";
            mapper += $"{selectCols}";
            mapper += $"\r\n    FROM";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n  </select>";
            mapper += $"\r\n";
            mapper += $"\r\n  <insert id=\"{table.ToSnakeCase("add")}\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    INSERT INTO";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n       ({insertCols})";
            mapper += $"\r\n    VALUES";
            mapper += $"{insertVals}";
            mapper += $"\r\n  </inesrt>";
            mapper += $"\r\n";
            mapper += $"\r\n  <update id=\"{table.ToSnakeCase("update")}\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    UPDATE";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n    SET";
            mapper += $"{updateCols}";
            mapper += $"\r\n    WHERE";
            mapper += $"{updateVals}";
            mapper += $"\r\n  </update>";
            mapper += $"\r\n";
            mapper += $"\r\n  <delete id=\"{table.ToSnakeCase("delete")}\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    DELETE FROM";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n    WHERE";
            mapper += $"{deleteVals}";
            mapper += $"\r\n  </delete>";
            mapper += $"</mapper>";

            return mapper;
        }
    }
}
