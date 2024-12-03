using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string folder = "FileCollection";
            const string resultFile = "result.txt";

            string new_path_xls = "";
            string new_path_ppt = "";
            string new_path_doc = "";
            string new_path_txt = "";
            string new_path_jpg = "";
            
           DirectoryInfo di = new DirectoryInfo(folder);

            new_path_xls=di.FullName+"\\XLSX";
            new_path_ppt = di.FullName + "\\PPT";
            new_path_doc = di.FullName + "\\DOC";
            new_path_txt = di.FullName + "\\TXT";
            new_path_jpg = di.FullName + "\\JPG";

            if(!Directory.Exists(new_path_xls))
            {
                Directory.CreateDirectory(new_path_xls);
            }
            if (!Directory.Exists(new_path_doc))
            {
                Directory.CreateDirectory(new_path_doc);
            }
            if (!Directory.Exists(new_path_ppt))
            {
                Directory.CreateDirectory(new_path_ppt);
            }
            if (!Directory.Exists(new_path_txt))
            {
                Directory.CreateDirectory(new_path_txt);
            }
            if (!Directory.Exists(new_path_jpg))
            {
                Directory.CreateDirectory(new_path_jpg);
            }

            bool IsOfficeFile(string filename)
            {
                if (
                    filename.EndsWith(".xlsx")|| filename.EndsWith(".docx")|| filename.EndsWith(".pptx")
                    )
                    return true;
                return false;
            }


            foreach (FileInfo fi in di.EnumerateFiles())
            {

                if (IsOfficeFile(fi.Name))
                {                    
                
                    if(fi.Name.EndsWith(".xlsx"))
                    { 
                    
                    fi.MoveTo(new_path_xls+"\\"+fi.Name);

                    }
                    if (fi.Name.EndsWith(".pptx"))
                    {

                        fi.MoveTo(new_path_ppt + "\\" + fi.Name);

                    }
                    if (fi.Name.EndsWith(".docx"))
                    {

                        fi.MoveTo(new_path_doc + "\\" + fi.Name);

                    }
                    if (fi.Name.EndsWith(".txt"))
                    {

                        fi.MoveTo(new_path_txt + "\\" + fi.Name);

                    }
                    if (fi.Name.EndsWith(".jpg"))
                    {

                        fi.MoveTo(new_path_jpg + "\\" + fi.Name);

                    }



                }



            }



        }
    }
}
