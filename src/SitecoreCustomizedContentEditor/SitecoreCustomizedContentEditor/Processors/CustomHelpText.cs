using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Shell.Applications.ContentEditor;
using Sitecore.Shell.Applications.ContentEditor.Pipelines.RenderContentEditor;
using Sitecore.Shell.Applications.ContentManager;
using SitecoreCustomizedContentEditor.Processors;

namespace SitecoreCustomizedContentEditor
{

    public class CustomHelpText
    {
        public void Process(RenderContentEditorArgs args)
        {
            AddCSSFile(args.Parent);
            args.EditorFormatter = CreateCustomEditorFormatter(args);
            args.EditorFormatter.RenderSections(args.Parent, args.Sections, args.ReadOnly);
            
        }

        private static EditorFormatter CreateCustomEditorFormatter(RenderContentEditorArgs args)
        {
            return new CustomEditorFormatter
            {
                Arguments = args.EditorFormatter.Arguments,
                IsFieldEditor = args.EditorFormatter.IsFieldEditor
            };
        }
        private void AddCSSFile(Control parent)
        {
            HtmlGenericControl styleTag = new HtmlGenericControl();
            styleTag.TagName = "link";
            styleTag.Attributes.Add("href", "/sitecore/shell/Themes/Standard/Default/customhelptooltip.css");
            styleTag.Attributes.Add("rel", "stylesheet");
            styleTag.Attributes.Add("type", "text/css");
            parent.Page.Header.Controls.Add(styleTag);
        }

    }
}