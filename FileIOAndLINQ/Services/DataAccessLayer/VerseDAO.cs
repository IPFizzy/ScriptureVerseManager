/*
 * Keon Bushman
 * CST - 250
 * 06/28/2026
 * File I/O and LINQ
 * Activity 6
 */

using FileIOAndLINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.Xml.Serialization;

namespace FileIOAndLINQ.Services.DataAccessLayer
{
    class VerseDAO
    {
        // Declare class level variables
        List<VerseDataModel> _verses;

        /// <summary>
        /// Default constructor for VerseDAO
        /// </summary>
        public VerseDAO()
        {
            // Set the EPPlus license context
            ExcelPackage.License.SetNonCommercialPersonal("Keon Bushman");

            // Create a new List of VerseDataModels
            _verses = new List<VerseDataModel>();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseRequestModel verse)
        {
            // Declare and initialize
            int id = _verses.Count + 1;
            VerseDataModel newVerse = new VerseDataModel();

            // Create a new verse based on the verse request model
            newVerse = new VerseDataModel(id, verse.Book, verse.Chapter,
                verse.Verse, verse.Text, verse.Meaning, verse.Importance);

            // Add the new verse to the verses list
            _verses.Add(newVerse);

            // Return the id of the new verse
            return id;
        }

        /// <summary>
        /// Get the list of verses in the inventory
        /// </summary>
        /// <returns></returns>
        public List<VerseDataModel> GetAllVerses()
        {
            // Return the _verses list
            return _verses;
        }

        /// <summary>
        /// Write the verses list to the given file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string WriteVersesToFile(string fileName)
        {
            // Declare and initialize
            string serialized = "";

            // Create a switch based on the file extension
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    // Loop through the _verses list
                    foreach (VerseDataModel verse in _verses)
                    {
                        // Add each verse to the serialized string
                        serialized += verse.ToString() + "\n";
                    }
                    break;

                case ".json":
                    // Use ServiceStack to serialize to json
                    serialized = ServiceStack.Text.JsonSerializer.SerializeToString(_verses);
                    break;

                case ".csv":
                    // Use ServiceStack to serialize to csv
                    serialized = ServiceStack.Text.CsvSerializer.SerializeToString(_verses);
                    break;

                case ".xml":
                    // Use XmlSerializer to serialize to xml
                    serialized = SerializeVersesToXml();
                    break;

                case ".xlsx":
                    // Write the verses to an Excel file
                    return WriteVersesToExcelFile(fileName);

                default:
                    return "File not recognized";
            }

            try
            {
                // Use File.WriteAllText to send the serialized string to the file
                File.WriteAllText(fileName, serialized);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            // Return a success message to the user
            return "The verses have been saved to your file";
        }

        /// <summary>
        /// Serialize the verses list to XML
        /// </summary>
        /// <returns></returns>
        public string SerializeVersesToXml()
        {
            // Declare and initialize
            XmlSerializer serializer = new XmlSerializer(typeof(List<VerseDataModel>));

            // Create a string writer to hold the XML data
            using (StringWriter stringWriter = new StringWriter())
            {
                // Serialize the verses list
                serializer.Serialize(stringWriter, _verses);

                // Return the XML string
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// Write the verses list to an Excel file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string WriteVersesToExcelFile(string fileName)
        {
            try
            {
                // Create the Excel file object
                FileInfo excelFile = new FileInfo(fileName);

                // Create a new Excel package
                using (ExcelPackage package = new ExcelPackage())
                {
                    // Add a worksheet to the package
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Verses");

                    // Add column headers
                    worksheet.Cells[1, 1].Value = "Id";
                    worksheet.Cells[1, 2].Value = "Book";
                    worksheet.Cells[1, 3].Value = "Chapter";
                    worksheet.Cells[1, 4].Value = "Verse";
                    worksheet.Cells[1, 5].Value = "Text";
                    worksheet.Cells[1, 6].Value = "Meaning";
                    worksheet.Cells[1, 7].Value = "Importance";

                    // Loop through the verses list
                    for (int i = 0; i < _verses.Count; i++)
                    {
                        // Add the verse data to the worksheet
                        worksheet.Cells[i + 2, 1].Value = _verses[i].Id;
                        worksheet.Cells[i + 2, 2].Value = _verses[i].Book;
                        worksheet.Cells[i + 2, 3].Value = _verses[i].Chapter;
                        worksheet.Cells[i + 2, 4].Value = _verses[i].Verse;
                        worksheet.Cells[i + 2, 5].Value = _verses[i].Text;
                        worksheet.Cells[i + 2, 6].Value = _verses[i].Meaning;
                        worksheet.Cells[i + 2, 7].Value = _verses[i].Importance;
                    }

                    // Auto fit the columns
                    worksheet.Cells.AutoFitColumns();

                    // Save the Excel package
                    package.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            // Return a success message
            return "The verses have been saved to your Excel file";
        }

        /// <summary>
        /// Read verses from the given file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public string ReadVersesFromFile(string fileName)
        {
            // Declare and initialize
            string data = "";
            List<VerseDataModel> dataVerses = new List<VerseDataModel>();

            // Set up a try-catch to read files text
            try
            {
                // Get the text from the file
                data = File.ReadAllText(fileName);
            }
            catch (Exception ex)
            {
                // Return the exception message
                return ex.Message;
            }
            // Create a switch based on the file extension
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    // Split the text file on the newline character
                    string[] lines = data.Split("\n");

                    // Loop through the array of lines
                    foreach (string line in lines)
                    {
                        // Check if each line contains data
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            // If so, convert the data to a VerseDataModel
                            // and add it to the dataVerses list
                            dataVerses.Add(ConvertTxtToVerseDataModel(line));
                        }
                    }
                    break;

                case ".json":
                    // Deserialize the data using the JsonSerializer
                    dataVerses = ServiceStack.Text.JsonSerializer.DeserializeFromString<List<VerseDataModel>>(data);
                    break;

                case ".csv":
                    // Deserialize the data using the CsvSerializer
                    dataVerses = ServiceStack.Text.CsvSerializer.DeserializeFromString<List<VerseDataModel>>(data);
                    break;

                case ".xml":
                    // Deserialize the data using the XmlSerializer
                    dataVerses = DeserializeVersesFromXml(data);
                    break;

                case ".xlsx":
                    // Read the verses from the Excel file
                    dataVerses = ReadVersesFromExcelFile(fileName);
                    break;

                default:
                    // Return the issue to the user
                    return "File not recognized";
            }
            // Loop through the dataVerses list
            foreach (VerseDataModel newVerse in dataVerses)
            {
                // Set the id for each new verse
                newVerse.Id = _verses.Count + 1;

                // Add the new verse to the _verses list
                _verses.Add(newVerse);
            }

            // Return a success message to the user
            return "The verses have been read from your file and added to the list";
        } // End of ReadVersesFromFile

        /// <summary>
        /// Deserialize XML data into a list of VerseDataModels
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<VerseDataModel> DeserializeVersesFromXml(string data)
        {
            // Declare and initialize
            XmlSerializer serializer = new XmlSerializer(typeof(List<VerseDataModel>));
            List<VerseDataModel> dataVerses = new List<VerseDataModel>();

            // Create a string reader to read the XML data
            using (StringReader stringReader = new StringReader(data))
            {
                // Deserialize the XML data
                object? result = serializer.Deserialize(stringReader);

                // Check if the result contains verse data
                if (result is List<VerseDataModel> verses)
                {
                    // Set the data verses list
                    dataVerses = verses;
                }
            }

            // Return the data verses
            return dataVerses;
        }

        /// <summary>
        /// Read verses from an Excel file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<VerseDataModel> ReadVersesFromExcelFile(string fileName)
        {
            // Declare and initialize
            List<VerseDataModel> dataVerses = new List<VerseDataModel>();

            // Create the Excel file object
            FileInfo excelFile = new FileInfo(fileName);

            // Open the Excel package
            using (ExcelPackage package = new ExcelPackage(excelFile))
            {
                // Get the first worksheet
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Check if the worksheet has data
                if (worksheet.Dimension != null)
                {
                    // Loop through each row after the header row
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        // Declare and initialize
                        int id = 0, chapter = 0, importance = 0;

                        // Parse numeric values
                        int.TryParse(worksheet.Cells[row, 1].Text, out id);
                        int.TryParse(worksheet.Cells[row, 3].Text, out chapter);
                        int.TryParse(worksheet.Cells[row, 7].Text, out importance);

                        // Create the verse object
                        VerseDataModel verse = new VerseDataModel(
                            id,
                            worksheet.Cells[row, 2].Text,
                            chapter,
                            worksheet.Cells[row, 4].Text,
                            worksheet.Cells[row, 5].Text,
                            worksheet.Cells[row, 6].Text,
                            importance
                        );

                        // Add the verse to the list
                        dataVerses.Add(verse);
                    }
                }
            }

            // Return the verses from the Excel file
            return dataVerses;
        }

        /// <summary>
        /// Take a line from the text file and return a VerseDataModel
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public VerseDataModel ConvertTxtToVerseDataModel(string line)
        {
            // Declare and initialize
            string[] values;
            int chapter = 0, importance = 0;
            VerseDataModel verse;

            // Split the line on '* '
            values = line.Split("* ");

            // Use a try parse to parse the chapter
            int.TryParse(values[1], out chapter);

            // Parse the importance
            int.TryParse(values[5], out importance);

            // Create the new verse
            verse = new VerseDataModel(0, values[0], chapter, values[2], values[3], values[4], importance);

            // Return the verse
            return verse;
        }

        /// <summary>
        /// Get a list of the least important verses
        /// </summary>
        /// <param name="numToFind"></param>
        /// <returns></returns>
        public List<VerseDataModel> GetLeastImportantVerses(int numToFind)
        {
            // Use LINQ query syntax to order the verses and select how
            // many are needed based on the numToFind parameter
            List<VerseDataModel> leastImportantVerses = (from verse in _verses
                                                         orderby verse.Importance
                                                         select verse).Take(numToFind).ToList();

            // Return the list of least important verses
            return leastImportantVerses;
        }

        /// <summary>
        /// Convert a list of VerseDataModels to VerseDisplayModels
        /// </summary>
        /// <param name="dataVerses"></param>
        /// <returns></returns>
        public List<VerseDisplayModel> ConvertVerseDataToDisplay(List<VerseDataModel> dataVerses)
        {
            // Declare and initialize
            List<VerseDisplayModel> displayVerses = new List<VerseDisplayModel>();
            string reference = "";

            // Loop through the dataVerses list
            foreach (VerseDataModel verse in dataVerses)
            {
                // Use the book, chapter, and verse to create the reference
                reference = $"{verse.Book} {verse.Chapter}:{verse.Verse}";

                // Create a display verse model using the VerseDataModel verse
                VerseDisplayModel displayVerse = new VerseDisplayModel(reference, verse.Text, verse.Meaning, verse.Importance);

                // Add the display model to the displayVerses list
                displayVerses.Add(displayVerse);
            }

            // Return the display verses list
            return displayVerses;
        }

        /// <summary>
        /// Get a list of the most important verses
        /// </summary>
        /// <param name="numToFind"></param>
        /// <returns></returns>
        public List<VerseDataModel> GetMostImportantVerses(int numToFind)
        {
            // Use LINQ method syntax to order the verses and select how
            // many are needed based on the numToFind parameter
            List<VerseDataModel> mostImportantVerses = _verses.OrderByDescending(verse => verse.Importance).Take(numToFind).ToList();

            // Return the list of most important verses
            return mostImportantVerses;
        }

        /// <summary>
        /// Get the total number of verses saved
        /// </summary>
        /// <returns></returns>
        public int GetTotalVerseCount()
        {
            // Use LINQ to count the total number of verses including ranges
            int totalVerseCount = _verses.Sum(verse => CountVerseRange(verse.Verse));

            // Return the total verse count
            return totalVerseCount;
        }

        /// <summary>
        /// Count how many verses are included in a verse value
        /// </summary>
        /// <param name="verseValue"></param>
        /// <returns></returns>
        public int CountVerseRange(string verseValue)
        {
            // Check if the verse value is blank
            if (string.IsNullOrWhiteSpace(verseValue))
            {
                return 0;
            }

            // Normalize the verse value to handle regular and long dashes
            string cleanedVerse = verseValue.Replace("–", "-").Trim();

            // Check if the verse value is a range
            if (cleanedVerse.Contains("-"))
            {
                // Split the range
                string[] rangeParts = cleanedVerse.Split("-");

                // Check if the range has a start and end value
                if (rangeParts.Length == 2 &&
                    int.TryParse(rangeParts[0], out int startVerse) &&
                    int.TryParse(rangeParts[1], out int endVerse))
                {
                    // Return the number of verses in the range
                    return Math.Abs(endVerse - startVerse) + 1;
                }
            }

            // Check if the verse value is a single number
            if (int.TryParse(cleanedVerse, out int singleVerse))
            {
                return 1;
            }

            // Return 1 as the default for entered verse text
            return 1;
        }
    }
}
