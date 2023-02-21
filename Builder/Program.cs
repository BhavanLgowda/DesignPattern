﻿namespace BuilderDemo
{
     class Program
    {
        static void Main(string[] args)
        { 
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            PdfReport pdfReport = new PdfReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();

            Console.WriteLine("-------------------");

            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
     }
}