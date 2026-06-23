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
        /// <param name="filename"></param>
        /// <returns></returns>
        public string WriteVersesToFile(string fileName)
        {
            // Declare and initialize
            string serialized = "";

            // Create a switch based on the file extension
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                    // Loop through the _verse list
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
        }
    }
