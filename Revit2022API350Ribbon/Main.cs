using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Revit2022API350Ribbon
{
    [Transaction(TransactionMode.Manual)]

    public class Main : IExternalApplication

    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "RevitAPITraining";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\PROG\App\DLL\";

            var panel1 = application.CreateRibbonPanel(tabName, "Лента №1");
            var panel2 = application.CreateRibbonPanel(tabName, "Лента №2");

            var buttonCalculate = new PushButtonData(
                "Система",
                "Подсчет количества",
                Path.Combine(utilsFolderPath, "Revit2022API351.dll"),
                "Revit2022API351.Main");

            var buttonChangeTypeWall = new PushButtonData(
                "Система",
                "Смена типа стен",
                Path.Combine(utilsFolderPath, "Revit2022API352.dll"),
                "Revit2022API352.Main");

            panel1.AddItem(buttonCalculate);
            panel2.AddItem(buttonChangeTypeWall);

            return Result.Succeeded;

            //var panel = application.CreateRibbonPanel(tabName, "Лента");

            //var buttonCalculate = new PushButtonData(
            //    "Кнопка 1",
            //    "Подсчет количества",
            //    Path.Combine(utilsFolderPath, "Revit2022API351.dll"),
            //    "Revit2022API351.Main");

            //var buttonChangeTypeWall = new PushButtonData(
            //    "Кнопка 2",
            //    "Смена типа стен",
            //    Path.Combine(utilsFolderPath, "Revit2022API352.dll"),
            //    "Revit2022API352.Main");

            //panel.AddItem(buttonCalculate);
            //panel.AddItem(buttonChangeTypeWall);

            //return Result.Succeeded;


        }
    }
}
