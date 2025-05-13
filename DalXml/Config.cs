
using System.ComponentModel;
using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    const string filePath = @"..\xml\data-config.xml";
    static XElement runId = XElement.Load(filePath);

    public static int ProductRunId
    {
		get {

            int productRunId;
            if(!int.TryParse(runId.Element("ProductRunId").Value,out productRunId))
              productRunId=100;

            runId.Element("ProductRunId").SetValue(productRunId + 50);
            runId.Save(filePath);
            return productRunId;
             }
    }

    public static int SaleRunId
    {
        get
        {

            int saleRunId;
            if (!int.TryParse(runId.Element("SaleRunId").Value, out saleRunId))
                saleRunId = 100;

            runId.Element("SaleRunId").SetValue(saleRunId + 50);
            runId.Save(filePath);
            return saleRunId;
        }
    }


}
