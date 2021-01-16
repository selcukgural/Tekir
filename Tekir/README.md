# Tekir ![:(](https://github.com/selcukgural/Tekir/blob/Tekir_Sample/Tekir/src/image/32px.png "Tekir")

Tekir is a **Markdown** creator for .Net apps. Allows you to create Markdown file over class objects. Also Tekir supports almost all Markdown tags. Actually if you want try a manually simple Markdown file Tekir a little bit want more effect but **it may be more useful if you want to create a dynamic Markdown file according to certain conditions via a program.**


You can save the markdown file to your disk like that. You can also extend the **Save** method using the `IEntry` interface.


For more information please check [Tekir_Sample](https://github.com/selcukgural/Tekir/tree/Tekir_Sample/Tekir_Sample) project [Program.cs](https://github.com/selcukgural/Tekir/blob/Tekir_Sample/Tekir_Sample/Program.cs) file.


**Note:** This README.md file created by Tekir.


# Samples

```csharp
var markdown = new Markdown();
markdown.AddLine(new Heading(HeadingLevel.One, "Tekir ",
    new Image("Tekir", "https://github.com/selcukgural/Tekir/blob/main/src/image/64px.png")))
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
```
The Get method will return the **Markdown string**. You can always call
```csharp
markdown.Get();
```

## Table
`Input`


```csharp
var table = new Table();
table.Columns.Add(new Column("Test", Alignment.Left));
table.Columns.Add(new Column("Test 2", Alignment.Center));
table.Columns.Add(new Column("Test 3", Alignment.Right));
table.Columns.Add(new Column("Test 4"));

table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" });
table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" });
table.Rows.Add(new[] { "Column 1", "Column 2", "Column 3", "Column 4" });
```


`Output`

|Test|Test 2|Test 3|Test 4|
|----|:----:|-----:|------|
|Column 1|Column 2|Column 3|Column 4|
|Column 1|Column 2|Column 3|Column 4|
|Column 1|Column 2|Column 3|Column 4|



## List Element

- List element 1
- List element 2
- List element 3



## Ordered List

1. Ordered item 1
2. Ordered item 2
3. Ordered item 3



## UnOrderedList

* Item 1
    * Sub item 1
    * Sub item 2
* Item 2
    * Sub item 1
    * Sub item 2
* Item 3
    * Sub item 1
    * Sub item 2
    * Sub item 3



## Image

![:(](https://upload.wikimedia.org/wikipedia/en/6/6b/Voltron_logo.png "Voltron")


## Linked Image

[![alt text](https://upload.wikimedia.org/wikipedia/en/6/6b/Voltron_logo.png "Voltron")](https://en.wikipedia.org/wiki/Voltron)


`Headers`
---
###### Header 6
##### Header 5
#### Header 4
### Header 3
## Header 2
# Header 1
---

## Fenced Code
```Fenced Code Sample...```
## Email or Url
<https://selcukgural.com>
## Italic
*Italic sample...*
## Bold
**Bold sample...**
## Escape Character
\-
## Link
[Click me!](https://github.com)
## Section
[Section](#Italic)
## Block Quote
> Block quote sample...

## Nesned Block Quote
>> Block quote sample...
