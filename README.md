# Sitecore Customized Content Editor (HTML Tooltip)
**Sitecore version**: Sitecore 10.3.0 (rev. 008463)

 **Steps:** 
1) Comment out the following lines from Sitecore.config.
```
<renderContentEditor>
      <<processor type="Sitecore.Shell.Applications.ContentEditor.Pipelines.RenderContentEditor.RenderSkinedContentEditor, Sitecore.Client" />
      <processor type="Sitecore.Shell.Applications.ContentEditor.Pipelines.RenderContentEditor.RenderStandardContentEditor, Sitecore.Client" />
</renderContentEditor>
```
2) Install the sitecore package Package/TooltipHTMLField-1.zip.
3) Publish the project to the root folder of Sitecore.
4) Navigate to "HTML Tooltip" field, and add your rich text content, you should see an icon on each field for this tooltip that will display and HTML content.
  <br/>
**screenshots:**   
  <img src="screenshot/video.gif" />
  <br/>
  <img src="screenshot/template.png" />
  <br/>
  <img src="screenshot/item.png" />