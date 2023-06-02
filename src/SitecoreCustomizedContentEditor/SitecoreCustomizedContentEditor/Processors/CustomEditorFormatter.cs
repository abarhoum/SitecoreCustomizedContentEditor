using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Shell.Applications.ContentEditor;
using Sitecore.Shell.Applications.ContentManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SitecoreCustomizedContentEditor.Processors
{
    public class CustomEditorFormatter : EditorFormatter
    {
        public override void RenderField(Control parent, Editor.Field field, bool readOnly)
        {
            Field itemField = field.ItemField;
            Item fieldType = GetFieldType(itemField);
            if (fieldType != null)
            {
                RenderMarkerBegin(parent, field.ControlID);
                RenderMenuButtons(parent, field, fieldType, readOnly);
                RenderLabel(parent, field, fieldType, readOnly);
                if (!itemField.Definition.Template.FullName.Contains("System/Templates/"))
                {
                    AddIcon(parent, field);
                }
                RenderField(parent, field, fieldType, readOnly);
                RenderMarkerEnd(parent);
            }

        }

        public void AddIcon(Control parent, Editor.Field field)
        {
            AddLiteralControl(parent, GenerateIcon(field));
            

        }
        private static string GenerateIcon(Editor.Field field)
        {
            var toolTip = string.Empty;
            var toolTipField = field.ItemField.Database.GetItem(field.ItemField.ID);
            if (toolTipField != null && toolTipField.Fields != null && toolTipField.Fields["__HTML Tooltip"] != null)
            {
                toolTip = toolTipField.Fields["__HTML Tooltip"].Value;
            }
             return string.Format("<div class='tooltip'>{0}<span class='tooltiptext'>{1}</span></div>", GetIcon(),toolTip);
            //return string.Format("<a title=\"field tooltip = {0}\" style=\"float: right;margin-top:-20px;right:15px;\" href =\"#\">{1}</a>", toolTip,  GetIcon());
        }
        private static string GetIcon()
        {
            return "<img style=\"border: 0;\" src=\"/~/icon/Applications/16x16/information2.png\" width=\"16\" height=\"16\" />";
        }
       

    }
}