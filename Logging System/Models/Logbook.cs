using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Logging_System.Models
{
    public class Logbook
    {
        //The information


        [Required(ErrorMessage ="Ignore,Unless incorrect")]
        
        [Display(Name = "Learner's Name:")]
        public string LearnerName { get; set;}

        [Display(Name = "Mentor's Name:")]
        [Required(ErrorMessage = "Ignore,Unless incorrect")]
        public string MentorName { get; set; }

        [Display(Name = "Mentors's Tel:")]
        [Required(ErrorMessage = "Ignore,Unless incorrect")]
        public string MentorTel { get; set; }
        
        [Required(ErrorMessage = "Select appropriate")]
        [Display(Name = "Learnership Intake:")]
        public string Learnership { get; set; }
        [Required(ErrorMessage = "Select appropriate")]
        [Display(Name = "Company Name:")]
        public string CompanyName { get; set; }


        //Day One--Monday

            
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Monday's Date:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? Day01 { get; set; }

        [Required]
        [Display(Name = "Task Completed:")]
        public string TaskDay01 { get; set; }


        [Required]
        [Display(Name = "Completed(Satisfactory)?:")]
        public string CompletedSatDay01 { get; set; }


        [Required]
        [Display(Name = "Time Taken(Hours):")]
        public string TimeTakenDay01 { get; set; }
      

        [Required]
        [Display(Name = "Problems Experienced(If Any)")]
        public string ProblemsDay01 { get; set; }
        [Display(Name = "General Comments:")]

        [Required]
        public string CommentsDay01 { get; set; }


        //Day 2 Tuesday

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Tuesday's Date:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? Day02 { get; set; }

        [Required]
        [Display(Name = "Task Completed:")]
        public string TaskDay02 { get; set; }


        [Required]
        [Display(Name = "Completed(Satisfaction)?:")]
        public string CompletedSatDay02 { get; set; }


        [Required]
        [Display(Name = "Time Taken(Hours):")]
        public string TimeTakenDay02 { get; set; }


        [Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay02 { get; set; }
        [Display(Name = "General Comments:")]

        [Required]
        public string CommentsDay02 { get; set; }

        //Day 03 Wednesday

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Wednesday's Date:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? Day03 { get; set; }

        [Required]
        [Display(Name = "Task Completed:")]
        public string TaskDay03 { get; set; }


        [Required]
        [Display(Name = "Completed(Satisfaction)?:")]
        public string CompletedSatDay03 { get; set; }


        [Required]
        [Display(Name = "Time Taken(Hours):")]
        public string TimeTakenDay03 { get; set; }


        [Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay03 { get; set; }
        [Display(Name = "General Comments:")]

        [Required]
        public string CommentsDay03 { get; set; }

        //Day 4 Thursday

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Thursday's Date:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? Day04 { get; set; }

        [Required]
        [Display(Name = "Task Completed:")]
        public string TaskDay04 { get; set; }


        [Required]
        [Display(Name = "Completed(Satisfaction)?:")]
        public string CompletedSatDay04 { get; set; }


        [Required]
        [Display(Name = "Time Taken(Hours):")]
        public string TimeTakenDay04 { get; set; }


        [Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay04 { get; set; }
        [Display(Name = "General Comments:")]

        [Required]
        public string CommentsDay04 { get; set; }

        //Day 5 Friday

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Friday's Date:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? Day05 { get; set; }

        [Required]
        [Display(Name = "Task Completed:")]
        public string TaskDay05 { get; set; }


        [Required]
        [Display(Name = "Completed(Satisfaction)?:")]
        public string CompletedSatDay05 { get; set; }


        [Required]
        [Display(Name = "Time Taken(Hours):")]
        public string TimeTakenDay05 { get; set; }


        [Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay05 { get; set; }
        [Display(Name = "General Comments:")]

        [Required]
        public string CommentsDay05 { get; set; }


        

        [Required]
        [Display(Name = "Learner's Signature:")]
        public string LearnerSignature { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Date Learner Signed:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? DateLearnerSigned { get; set; }


        //Allow preview
        [Display(Name = "Logbook Preview:")]
        public RadioCheckField Preview { get; set; }
        





        public string CreateLogbook(Logbook _logbook)
        {
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            DateTime Created = DateTime.Now;
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("C:\\Users\\SMarimi\\Desktop\\Learners-Logging-System\\Learners--Logging-System\\Logging System\\WeeklyLogbooks\\" + _logbook.LearnerName + ".pdf", FileMode.Create));

            
            document.Open();

            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("C:\\Users\\SMarimi\\Documents\\Visual Studio 2015\\Projects\\Profile\\Profile\\img\\android.png");
            document.Add(PNG);
            PNG.ScalePercent(25f);
            PNG.SetAbsolutePosition(document.PageSize.Width + 36f + 72f, document.PageSize.Height + 36f + 216.6f);

            Paragraph info = new Paragraph();//("Invoice Number: " + inv + invoice + "\r\n");
            string line = "";
            info.Add("                                                Learner Daily Log                                       " + "\r\n");
            info.Add(line);
            info.Add(line);
           

            info.Add("LEARNER DAILY ACTIVITIES LOGBOOK");
            info.Add(line);
            info.Add(line);
            info.Add(line);
            info.Add("Learner's Name: " + _logbook.LearnerName + "\r\n");
            info.Add(line);
            info.Add("Mentor's Name and Tel: " + _logbook.MentorName +  _logbook.MentorTel+ "\r\n");
            info.Add(line);
            info.Add(line);
            info.Add("Learnership Intake: " + _logbook.Learnership + "\r\n");
            info.Add(line);
            info.Add("Company Name: " + _logbook.CompanyName + "\r\n");
            info.Add(line);
            info.Add("Please refer to Workplace Task Maping for a breakdown of prescribed activities.");


           

            info.Add(line);
            document.Add(info);



            PdfPTable table = new PdfPTable(3);

            PdfPCell Cell = new PdfPCell(new Phrase("Product"));
            Cell.Colspan = 1;
            Cell.HorizontalAlignment = 0;
            table.AddCell(Cell);


            //table.AddCell("Price (Rands)");    //col1 row 1
            //table.AddCell("Quantity");  //col 2 row 1
            //table.AddCell(logbook.name + ""); //col 3 row 1
            //table.AddCell(logbook.surname + ""); // col 4 row 1
            //table.AddCell(logbook.name + "");

            //table.AddCell(logbook.name + ""); //col 3 row 1
            //table.AddCell(logbook.surname + ""); // col 4 row 1
            //table.AddCell(logbook.name + "");

            //table.AddCell(logbook.name + ""); //col 3 row 1
            //table.AddCell(logbook.surname + ""); // col 4 row 1
            //table.AddCell(logbook.name + "");

            //table.AddCell(logbook.name + ""); //col 3 row 1
            //table.AddCell(logbook.surname + ""); // col 4 row 1
            //table.AddCell(logbook.name + "");


            document.Add(table);



            document.Close();
            System.Diagnostics.Process.Start("C:\\Users\\SMarimi\\Desktop\\Learners-Logging-System\\Learners--Logging-System\\Logging System\\WeeklyLogbooks\\"+ _logbook.LearnerName + ".pdf");

            try
            {


                return "Successfully Submitted Logbook " + _logbook.LearnerName;
            }
            catch (Exception es)
            {
                throw es;
            }
        }




    }
}