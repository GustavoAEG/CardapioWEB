using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CardapioWEB_Demo.TagHelpers
{
    // Renomeie o namespace para evitar colisões
    public class EmailTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
    {
        public string Endereco { get; set; }
        public string Conteudo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Endereco);
            output.Content.SetContent(Conteudo);
        }
    }
}
