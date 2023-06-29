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


            var mapper = string.Empty;

            mapper += $"<?xml version=\"1.0\" encoding=\"UTF - 8\"?>";
            mapper += $"\r\n<!DOCTYPE mapper PUBLIC \" -//mybatis.org//DTD Mapper 3.0//EN\"";
            mapper += $"\r\n  \"http://mybatis.org/dtd/mybatis-3-mapper.dtd\">";
            mapper += $"\r\n<mapper namespace=\"gopos.master.dao.MasterDAO\">";
            mapper += $"\r\n";
            mapper += $"\r\n  <select id=\"getPsCmCode\" parameterType=\"HashMap\" resultType=\"LinkedHashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    SELECT";
            mapper += $"\r\n      {"쿼리"}";
            mapper += $"\r\n    FROM";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n  </select>";
            mapper += $"\r\n";
            mapper += $"\r\n  <insert id=\"getPsCmCode\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    INSERT INTO";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n      {"컬럼"}";
            mapper += $"\r\n    VALUES";
            mapper += $"\r\n      {"테이블"}";
            mapper += $"\r\n  </inesrt>";
            mapper += $"\r\n";
            mapper += $"\r\n  <update id=\"getPsCmCode\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    UPDATE";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n    SET";
            mapper += $"\r\n      {cols}";
            mapper += $"\r\n    WHERE";
            mapper += $"\r\n      {cols}";
            mapper += $"\r\n  </update>";
            mapper += $"\r\n";
            mapper += $"\r\n  <delete id=\"getPsCmCode\" parameterType=\"HashMap\">";
            mapper += $"\r\n    /* {"주석"} */";
            mapper += $"\r\n    DELETE FROM";
            mapper += $"\r\n      {table}";
            mapper += $"\r\n    WHERE";
            mapper += $"\r\n      {"테이블"}";
            mapper += $"\r\n  </delete>";

            return mapper;
        }
    }
}
