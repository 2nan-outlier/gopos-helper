using GoposExcelToDbHelper.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoposExcelToDbHelper.Utils
{
    public static class ClassFileMaker
    {
        public static void Controller(string path, string package, string fileNm)
        {
            var lines = new List<string>() {
                $"package gopos.{package};",
                "",
                $"import gopos.{package}.service.{fileNm}Service;",
                "import lombok.AllArgsConstructor;",
                "import lombok.extern.slf4j.Slf4j;",
                "import org.springframework.beans.factory.annotation.Autowired;",
                "import org.springframework.web.bind.annotation.RequestMapping;",
                "import org.springframework.web.bind.annotation.RestController;",
                "",
                "@Slf4j",
                "@RestController",
                "@AllArgsConstructor",
                "@RequestMapping(\"\")",
                $"public class {fileNm}Controller {{",
                "  ",
                $"  @Autowired",
                $"  private {fileNm}Service {fileNm.StartLowerCase()}Service;",
                "  ",
                "}"
            };

            File.WriteAllLines($@"{path}\{fileNm}Controller.java", lines);
        }

        public static void Service(string path, string package, string fileNm)
        {
            var lines = new List<string>() {
                $"package gopos.{package}.service;",
                "",
                $"import gopos.{package}.dao.{fileNm}DAO;",
                "import lombok.AllArgsConstructor;",
                "import lombok.extern.slf4j.Slf4j;",
                "import org.springframework.beans.factory.annotation.Autowired;",
                "import org.springframework.stereotype.Service;",
                "",
                "@Slf4j",
                "@Service",
                "@AllArgsConstructor",
                $"public class {fileNm}Service {{",
                "  ",
                $"  @Autowired",
                $"  private {fileNm}DAO {fileNm.StartLowerCase()}Dao;",
                "  ",
                "}"
            };

            File.WriteAllLines($@"{path}\{fileNm}Service.java", lines);
        }

        public static void Dao(string path, string package, string fileNm)
        {
            var lines = new List<string>() {
                $"package gopos.{package}.dao;",
                "",
                "import org.apache.ibatis.annotations.Mapper;",
                "",
                "@Mapper",
                $"public interface {fileNm}DAO {{",
                "  ",
                "}"
            };

            File.WriteAllLines($@"{path}\{fileNm}DAO.java", lines);
        }

        public static void Mapper(string path, string package, string fileNm, List<string> lines)
        {
            File.WriteAllLines($@"{path}\{fileNm}Mapper.xml", lines);
        }
    }
}
