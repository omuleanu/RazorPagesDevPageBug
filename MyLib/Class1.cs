using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text.Encodings.Web;

namespace MyLib
{
    public class MyList : IHtmlContent
    {
        string render()
        {
            var res = JsonConvert.SerializeObject(new { Item1 = "abc" });
            return "list";
        }

        public void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            writer.Write(render());
        }
    }

    public static class Helpers
    {
        public static MyList MyList1(this IHtmlHelper helper)
        {
            return new MyList();
        }
    }
}