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


        [Required(ErrorMessage = "Ignore,Unless incorrect")]

        [Display(Name = "Learner's Name:")]
        public string LearnerName { get; set; }

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
        [DisplayFormat(DataFormatString = "{MMMM dd, yyyy}", ApplyFormatInEditMode = true)]
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


        //[Required]
        [Display(Name = "Problems Experienced(If Any)")]
        public string ProblemsDay01 { get; set; }
        [Display(Name = "General Comments:")]

        //[Required]
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


        //[Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay02 { get; set; }
        [Display(Name = "General Comments:")]

        //[Required]
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


        //[Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay03 { get; set; }
        [Display(Name = "General Comments:")]

        //[Required]
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


        //[Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay04 { get; set; }
        [Display(Name = "General Comments:")]

        //[Required]
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


        //[Required]
        [Display(Name = "Problems Experienced(If any)")]
        public string ProblemsDay05 { get; set; }
        [Display(Name = "General Comments:")]

        //[Required]
        public string CommentsDay05 { get; set; }




        [Required]
        [Display(Name = "Learner's Signature:")]
        public string LearnerSignature { get; set; }

        [Display(Name = "Signature FontSyle")]
        public string fontStyle { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Date Learner Signed:")]
        [DisplayFormat(DataFormatString = "{0:DD-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime? DateLearnerSigned { get; set; }


        //Allow preview
        [Display(Name = "Would you like to preview your Logbook? (Tick if YES)")]
        public string Preview { get; set; }








        public string CreateLogbook(Logbook _logbook)
        {





            string Date = DateLearnerSigned.ToString();
            string WL = "Weekly Logbook";
            // Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
            //Document document = new Document(new RectangleReadOnly(842, 595), 88f, 88f, 10f, 10f);
            // Document document = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            DateTime Created = DateTime.Now;

            //Checking and Creating folder with name date
            string folderfilter;
            string day;
            string month;
            string yaer;


            day = Created.Day.ToString();
            month = Created.ToString("MMMM");
            yaer = Created.Year.ToString();

            folderfilter = day + "-" + month + "-" + yaer;

            //My path
            string path = "C:\\Users\\SMarimi\\Desktop\\Learners-Logging-System\\Learners--Logging-System\\Logging System\\WeeklyLogbooks\\" + folderfilter + "\\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }



            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path + _logbook.LearnerName + " " + WL + ".pdf", FileMode.Create));



            document.Open();



            Font arial = FontFactory.GetFont("Arial", 12, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);





            Paragraph info = new Paragraph();
            Paragraph infos = new Paragraph();
            Paragraph small = new Paragraph();
            Paragraph smallb = new Paragraph();
            Paragraph inforhead = new Paragraph();
            Paragraph head = new Paragraph();

            inforhead.SpacingBefore = 12;
            head.SpacingAfter = 14;
            small.SpacingBefore = 10;



            iTextSharp.text.Font contentFont = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL);
            info.Font = contentFont;

            iTextSharp.text.Font smallfont = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
            small.Font = smallfont;

            iTextSharp.text.Font heads = iTextSharp.text.FontFactory.GetFont("Calibri(body)", 12, iTextSharp.text.Font.BOLD);
            heads.SetStyle(Font.ITALIC);

            head.Font = heads;

            iTextSharp.text.Font smallbold = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL);
            smallbold.SetStyle(Font.BOLD);
            smallb.Font = smallbold;

            iTextSharp.text.Font infohea = iTextSharp.text.FontFactory.GetFont("Calibri(body)", 12, iTextSharp.text.Font.BOLD);
            infohea.SetStyle(Font.ITALIC);
            inforhead.Font = infohea;



            //For name
            iTextSharp.text.Font contentTop = iTextSharp.text.FontFactory.GetFont("Arial", 13, iTextSharp.text.Font.ITALIC);
            contentTop.SetStyle(Font.BOLD);
            contentTop.SetStyle(Font.UNDERLINE);

            info.Font = contentFont;
            infos.Font = contentTop;
            string line = "           ";
            //info.Add("                                                           Learner Daily Log                                       " + "\r\n");
            info.Add(line);
            info.Add(line);
            info.Add(line + line + line + line + line + line + line + line + line + line + line + line + "Learner Daily Log  " + "\r\n");
            head.Add("LEARNER DAILY ACTIVITIES LOGBOOK  " + "\r\n");
            info.Add(line + "\r\n");
            infos.Add("Learner's Name: " + _logbook.LearnerName + "\r\n");
            info.Add(line + "\r\n");
            infos.Add("Mentor's Name and Tel: " + _logbook.MentorName + ": " + _logbook.MentorTel + "\r\n");
            info.Add(line + "\r\n");
            infos.Add("Learnership Intake: " + _logbook.Learnership + "\r\n");
            info.Add(line + "\r\n");
            infos.Add("Company Name: " + _logbook.CompanyName);
            inforhead.Add("Please refer to Workplace Task Maping for a breakdown of prescribed activities." + "\r\n");
            info.Add(line + "\r\n");
            info.Add(line + "\r\n");
            small.Add("This form must be completed everyday and signed off by both the Learner and respective Mentor." + "\r\n");
            small.Add("This form is intended for generic use.");

            smallb.Add("Please return to Torque IT at the follwing Fax number every friday:086 632 9687 or Thembekile.Madlala@torque-it.com and copy.");

            infos.Add(line + "\r\n");
            document.Add(info);
            document.Add(head);
            document.Add(infos);
            document.Add(small);
            document.Add(smallb);
            document.Add(inforhead);



            PdfPTable table = new PdfPTable(8);
            table.SpacingBefore = 14;
            // table.TotalWidth = 50;
            table.WidthPercentage = 100;



            //Checking which font was selected
            Font selectedFont;

            Font arialsignature = FontFactory.GetFont("Bradley Hand ITC", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

            Font arialsignature1 = FontFactory.GetFont("Blackadder ITC", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

            Font arialsignature2 = FontFactory.GetFont("Brush Script Std", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

            Font arialsignature3 = FontFactory.GetFont("Buxton Sketch", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

            Font arialsignature4 = FontFactory.GetFont("Informal Roman", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

            Font arialsignature5 = FontFactory.GetFont("Matura MT Script Capitals", 13, BaseColor.BLACK);
            arial.SetStyle(Font.BOLD);

                        
            PdfPCell Cell = new PdfPCell(new Phrase("Date", new Font(arial)));
            PdfPCell Cell1 = new PdfPCell(new Phrase("Task/s Completed", new Font(arial)));
            PdfPCell Cell2 = new PdfPCell(new Phrase("Completed to satidfaction Yes/No", new Font(arial)));
            PdfPCell Cell3 = new PdfPCell(new Phrase("Time Taken in Hours", new Font(arial)));
            PdfPCell Cell4 = new PdfPCell(new Phrase("Problems Experienced(if any)", new Font(arial)));
            PdfPCell Cell5 = new PdfPCell(new Phrase("General Comments", new Font(arial)));
            PdfPCell Cell6 = new PdfPCell(new Phrase("Learner's Signature", new Font(arialsignature3)));
            PdfPCell Cell7 = new PdfPCell(new Phrase("Mentor's Signature", new Font(arial)));




            Cell.Colspan = 1;
            Cell.HorizontalAlignment = 1;
            table.AddCell(Cell).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell1).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell2).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell3).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell4).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell5).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell6).BackgroundColor = BaseColor.LIGHT_GRAY;
            table.AddCell(Cell7).BackgroundColor = BaseColor.LIGHT_GRAY;



            //1st Row
            table.AddCell(_logbook.Day01.Value.ToShortDateString());
            table.AddCell(_logbook.TaskDay01);
            table.AddCell(_logbook.CompletedSatDay01);
            table.AddCell(_logbook.TimeTakenDay01);
            table.AddCell(_logbook.ProblemsDay01);
            table.AddCell(_logbook.CommentsDay01);
            table.AddCell(_logbook.LearnerSignature);
            table.AddCell("M.Huna");

            //2nd Row

            table.AddCell(_logbook.Day02.Value.ToShortDateString());
            table.AddCell(_logbook.TaskDay02);
            table.AddCell(_logbook.CompletedSatDay02);
            table.AddCell(_logbook.TimeTakenDay02);
            table.AddCell(_logbook.ProblemsDay02);
            table.AddCell(_logbook.CommentsDay02);
            table.AddCell(_logbook.LearnerSignature);
            table.AddCell("M.Huna");

            //3rd Row
            
            table.AddCell(_logbook.Day03.Value.ToShortDateString());
            table.AddCell(_logbook.TaskDay03);
            table.AddCell(_logbook.CompletedSatDay03);
            table.AddCell(_logbook.TimeTakenDay03);
            table.AddCell(_logbook.ProblemsDay03);
            table.AddCell(_logbook.CommentsDay03);
            table.AddCell(_logbook.LearnerSignature);
            table.AddCell("M.Huna");

            //4th Row

            table.AddCell(_logbook.Day04.Value.ToShortDateString());
            table.AddCell(_logbook.TaskDay04);
            table.AddCell(_logbook.CompletedSatDay04);
            table.AddCell(_logbook.TimeTakenDay04);
            table.AddCell(_logbook.ProblemsDay04);
            table.AddCell(_logbook.CommentsDay04);
            table.AddCell(_logbook.LearnerSignature);
            table.AddCell("M.Huna");

            //5th Row

            table.AddCell(_logbook.Day05.Value.ToShortDateString());
            table.AddCell(_logbook.TaskDay05);
            table.AddCell(_logbook.CompletedSatDay05);
            table.AddCell(_logbook.TimeTakenDay05);
            table.AddCell(_logbook.ProblemsDay05);
            table.AddCell(_logbook.CommentsDay05);
            table.AddCell(_logbook.LearnerSignature);
            table.AddCell("M.Huna");
            info.Add("Prepared by the Torque Career Campus");
            info.Add(line + "\r\n");

            document.Add(table);




            document.Close();

            if (_logbook.Preview == "Yes")
            {
                System.Diagnostics.Process.Start("C:\\Users\\SMarimi\\Desktop\\Learners-Logging-System\\Learners--Logging-System\\Logging System\\WeeklyLogbooks\\" + folderfilter + "\\" + _logbook.LearnerName + " " + WL + ".pdf");
            }


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