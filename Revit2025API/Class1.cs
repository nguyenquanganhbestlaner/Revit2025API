 using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
namespace Revit2025API
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1: IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            ICollection<ElementId> selectElements = uidoc.Selection.GetElementIds();
            int totalCount = selectElements.Count;
            MessageBox.Show("Ban da chon  " + totalCount.ToString() + "elements");
            string IdList = "Danh sach ID cua doi tuowng:\n";
            foreach (ElementId e1 in selectElements)
            {
                IdList = IdList + e1.ToString() + "\n";
            }
            MessageBox.Show(IdList);
            return Result.Succeeded;
        }


    }
}
