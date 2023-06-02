# SitecoreCustomizedContentEditor
steps:
1) comment out the following lines from Sitecore.config.
```
<renderContentEditor>
      <<processor type="Sitecore.Shell.Applications.ContentEditor.Pipelines.RenderContentEditor.RenderSkinedContentEditor, Sitecore.Client" />
      <processor type="Sitecore.Shell.Applications.ContentEditor.Pipelines.RenderContentEditor.RenderStandardContentEditor, Sitecore.Client" />
</renderContentEditor>
```
2) Install the sitecore package Package/TooltipHTMLField-1.zip.
3) publish the project to the root folder of Sitecore.
4) navigate to HTML Tooltip and add your content you should see an icon on each field for this tooltip that will display and HTML content.
