# Scripture Verse Manager

A complete **C# Windows Forms application** for building, searching, ranking, importing, and exporting a personal Scripture verse library. The project combines file I/O, LINQ, validation, data binding, serialization, and a layered application structure in one focused desktop tool.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Windows%20Forms-Desktop-0078D4?style=flat-square&logo=windows11&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/LINQ-Queries-238636?style=flat-square" alt="LINQ" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Scripture Verse Manager is a desktop practice project for organizing Bible verses together with a personal meaning and importance rating. Users can add verses, search the collection in real time, rank entries by importance, count individual verses inside saved ranges, and move the collection between several common file formats.

The application separates presentation, business logic, data models, and file-access responsibilities so the UI is not responsible for serialization or query logic directly.

## Features

- Add Scripture references with book, chapter, verse, text, meaning, and importance
- Complete Old Testament and New Testament book selector
- Autocomplete for Bible book names
- Validation for required fields and numeric values
- Support for individual verses and ranges such as `3-5`
- Data-grid display with wrapped verse text and notes
- Real-time search across reference, verse text, meaning, and importance
- Display the most important saved verses
- Display the least important saved verses
- Adjustable number of ranked results to show
- Count the true number of verses represented by saved ranges
- Import and export verse data
- Support for TXT, CSV, JSON, XML, and Excel formats
- Model conversion between storage and display representations
- Layered presentation, business-logic, and data-access organization

## LINQ Usage

The project uses LINQ for practical collection operations rather than isolated examples.

Examples include:

- Searching multiple verse properties with `Where`
- Ranking verses with `OrderByDescending`
- Ranking lower-priority entries with query syntax and `orderby`
- Limiting ranked results with `Take`
- Counting all represented verses with `Sum`
- Converting query results into displayable lists with `ToList`

Both LINQ method syntax and query syntax are represented in the project.

## File I/O and Serialization

The verse library can be serialized and restored through several formats:

| Format | Implementation |
| --- | --- |
| TXT | Custom text serialization |
| CSV | ServiceStack.Text |
| JSON | ServiceStack.Text |
| XML | `XmlSerializer` |
| XLSX | EPPlus |

Excel exports include structured columns for the verse ID, book, chapter, verse, text, meaning, and importance rating.

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Desktop UI | Windows Forms |
| Queries | LINQ |
| Excel I/O | EPPlus 8.6.1 |
| CSV / JSON | ServiceStack.Text 10.0.8 |
| XML | .NET `XmlSerializer` |
| Architecture | Presentation, business-logic, data-access, and model layers |

## Project Structure

```text
FileIOAndLINQ/
├── FileIOAndLINQ/
│   ├── Models/
│   │   ├── VerseDataModel.cs
│   │   ├── VerseDisplayModel.cs
│   │   └── VerseRequestModel.cs
│   ├── PresentationLayer/
│   │   ├── FrmVerseList.cs
│   │   ├── FrmVerseList.Designer.cs
│   │   └── FrmVerseList.resx
│   ├── Services/
│   │   ├── BusinessLogicLayer/
│   │   │   └── VerseLogic.cs
│   │   └── DataAccessLayer/
│   │       └── VerseDAO.cs
│   ├── Program.cs
│   └── FileIOAndLINQ.csproj
└── FileIOAndLINQ.slnx
```

## Application Flow

1. Select a Bible book.
2. Enter the chapter and verse or verse range.
3. Add the verse text and personal meaning or notes.
4. Assign an importance value from 1 to 10.
5. Add the verse to the current library.
6. Search the library or filter it by highest or lowest importance.
7. Save the collection to a supported file format when needed.
8. Load previously saved verse data back into the application.

## Verse Range Counting

The application treats saved verse ranges as multiple verses when calculating the collection total.

For example:

```text
John 3:16      = 1 verse
Philippians 4:6-7 = 2 verses
Romans 8:38-39 = 2 verses
```

The range-counting logic normalizes standard and long dashes, parses the start and end values, and calculates the inclusive number of verses represented by the entry.

## Running the Project

### Requirements

- Windows 10 or Windows 11
- Visual Studio with .NET desktop development support, or the .NET 10 SDK

Clone the repository:

```bash
git clone https://github.com/IPFizzy/FileIOAndLINQ.git
cd FileIOAndLINQ
```

Open `FileIOAndLINQ.slnx` in Visual Studio and run the `FileIOAndLINQ` project.

From the command line:

```bash
dotnet build FileIOAndLINQ.slnx
```

Run the application with:

```bash
dotnet run --project FileIOAndLINQ/FileIOAndLINQ.csproj
```

## EPPlus License Note

The project uses EPPlus for Excel file support and configures it for personal noncommercial use. Anyone adapting the project for another purpose should review the current EPPlus licensing requirements before redistribution or commercial use.

## Practice Project Context

This repository began as a focused exercise in file I/O and LINQ and is preserved as a completed practice project. The finished application expands those concepts into a usable Scripture-management tool with validation, data binding, search, ranking, multiple serialization formats, and separated application layers.

## Recommended Repository Name

For a public portfolio, **`ScriptureVerseManager`** is a stronger repository name than `FileIOAndLINQ` because it describes the finished application instead of the programming concepts used to build it.

The internal project and namespaces can remain unchanged if the repository itself is renamed.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
