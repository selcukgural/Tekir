```csharp
using System;
using System.Collections.Generic;
using System.Text;
using Tekir;

namespace Tekir_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var markdown = new Markdown();
            markdown.AddLine(new Heading(HeadingLevel.One, "Tekir ",
                    new Image("Tekir", "https://github.com/selcukgural/Tekir/tree/master/Tekir/src/image/64px.png")))
                .AddLine(new HorizontalRule())
                .AddLine(new FreeText(
                    "Tekir is a **Markdown** creator for .Net apps. Allows you to create Markdown file over class objects. Also Tekir supports almost all Markdown tags. Actually if you want try a manually simple Markdown file Tekir a little bit want more effect but **it may be more useful if you want to create a dynamic Markdown file according to certain conditions via a program.**"))
                .AddLine(new Paragraph())
                .AddLine(new FreeText(
                    "You can save the markdown file to your disk like that. You can also extend the **Save** method using the `IEntry` interface."))
                .AddLine(new Paragraph())
                .AddLine(new FreeText("For more information please check **Tekir_Sample** project's `Program.cs` file."))
                .AddLine(new Paragraph())
                .AddLine(new FreeText("**Note:** This README.md file created by Tekir."))
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.One, "Samples"))
                .AddLine(new HorizontalRule(new Paragraph()))
                .AddLine(new SyntaxHighlighting())
                .AddLine(new FreeText("The Get method will return the **Markdown string**. You can always call"))
                .AddLine(new SyntaxHighlighting("Get();","csharp",new Paragraph()))
                .AddLine(new Heading(HeadingLevel.Two, "Table"));


            #region Markdown Table
            var table = new Table();
            table.Columns.Add(new Column("Test", Alignment.Left));
            table.Columns.Add(new Column("Test 2", Alignment.Center));
            table.Columns.Add(new Column("Test 3", Alignment.Right));
            table.Columns.Add(new Column("Test 4"));

            table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" });
            table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" });
            table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" }); 
            #endregion


            markdown.AddLine(new Code("Input"))
                .AddLine(new Paragraph())
                .AddLine(new SyntaxHighlighting(@"
                var table = new Table();
                table.Columns.Add(new Column(""Test"", Alignment.Left));
                table.Columns.Add(new Column(""Test 2"", Alignment.Center));
                table.Columns.Add(new Column(""Test 3"", Alignment.Right));
                table.Columns.Add(new Column(""Test 4""));

                table.Rows.Add(new[] { ""Column 1"", ""Column 2"", ""Column 3"", ""Column 4"" });
                table.Rows.Add(new[] { ""Column 1"", ""Column 2"", ""Column 3"", ""Column 4"" });
                table.Rows.Add(new[] { ""Column 1"", ""Column 2"", ""Column 3"", ""Column 4"" });", "csharp"))
                .AddLine(new Paragraph())
                .AddLine(new Code("Output"))
                .AddLine(table)
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.Two, "List Element", new Paragraph()))
                .AddLine(new ListElement(new[] {"List element 1", "List element 2", "List element 3"}))
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.Two, "Ordered List", new Paragraph()))
                .AddLine(new OrderedList(new[] {"Ordered item 1", "Ordered item 2", "Ordered item 3"}))
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.Two, "UnOrderedList", new Paragraph()))
                .AddLine(new UnOrderedList(new List<UnOrderedItem>
                {
                    new UnOrderedItem("Item 1", new[] {"Sub item 1", "Sub item 2"}),
                    new UnOrderedItem("Item 2", new[] {"Sub item 1", "Sub item 2"}),
                    new UnOrderedItem("Item 3", new[] {"Sub item 1", "Sub item 2", "Sub item 3"}),
                }))
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.Two, "Image", new Paragraph()))
                .AddLine(new Image("Voltron", "https://upload.wikimedia.org/wikipedia/en/6/6b/Voltron_logo.png"))
                .AddLine(new Paragraph())
                .AddLine(new Heading(HeadingLevel.Two, "Linked Image", new Paragraph()))
                .AddLine(new LinkedImage("Voltron", "https://upload.wikimedia.org/wikipedia/en/6/6b/Voltron_logo.png",
                    "https://en.wikipedia.org/wiki/Voltron"))
                .AddLine(new Paragraph())
                .AddLine(new Code("Headers"))
                .AddLine(new HorizontalRule())
                .AddLine(new Heading(HeadingLevel.Six, "Header 6"))
                .AddLine(new Heading(HeadingLevel.Five, "Header 5"))
                .AddLine(new Heading(HeadingLevel.Four, "Header 4"))
                .AddLine(new Heading(HeadingLevel.Three, "Header 3"))
                .AddLine(new Heading(HeadingLevel.Two, "Header 2"))
                .AddLine(new Heading(HeadingLevel.One, "Header 1"))
                .AddLine(new HorizontalRule(new Paragraph()))
                .AddLine(new Heading(HeadingLevel.Two, "Fenced Code"))
                .AddLine(new FencedCode("Fenced Code Sample..."))
                .AddLine(new Heading(HeadingLevel.Two, "Email or Url"))
                .AddLine(new UrlOrEmail("https://selcukgural.com"))
                .AddLine(new Heading(HeadingLevel.Two, "Italic"))
                .AddLine(new Italic("Italic sample..."))
                .AddLine(new Heading(HeadingLevel.Two, "Bold"))
                .AddLine(new Bold("Bold sample..."))
                .AddLine(new Heading(HeadingLevel.Two, "Escape Character"))
                .AddLine(new EscapeCharacter('-'))
                .AddLine(new Heading(HeadingLevel.Two, "Link"))
                .AddLine(new Link("Click me!", "https://github.com"))
                .AddLine(new Heading(HeadingLevel.Two, "Section"))
                .AddLine(new Section("Section", "Italic"))
                .AddLine(new Heading(HeadingLevel.Two, "Block Quote"))
                .AddLine(new BlockQuote("Block quote sample...", new Paragraph()))
                .AddLine(new Heading(HeadingLevel.Two, "Nesned Block Quote"))
                .AddLine(new NestedBlockQuote("Block quote sample...")).Save(new FileEntry
                {
                    //This line will save the markdown content to your disk.
                    FileContent = markdown.Get(), Encoding = Encoding.UTF8 /*Default*/, FullFileName = @"D:\README.md"
                });

            // Markdown string
            var markdownContent = markdown.Get();
            Console.WriteLine(markdownContent);

            Console.ReadKey();

        }
    }
}
```
