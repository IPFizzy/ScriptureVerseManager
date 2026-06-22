/*
 * Keon Bushman
 * CST - 250
 * 06/28/2026
 * File I/O and LINQ
 * Activity 6
 */

using FileIOAndLINQ.Models;
using FileIOAndLINQ.Services.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOAndLINQ.Services.BusinessLogicLayer
{
    class VerseLogic
    {
        // Class level variables
        private VerseDAO _verseDAO;

        /// <summary>
        /// Default constructor for VerseLogic
        /// </summary>
        public VerseLogic()
        {
            // Initialize the data access object
            _verseDAO = new VerseDAO();
        }

        /// <summary>
        /// Add a new verse to the inventory
        /// </summary>
        /// <param name="verse"></param>
        /// <returns></returns>
        public int AddVerse(VerseRequestModel verse)
        {
            // Return the DAO method
            return _verseDAO.AddVerse(verse);
        }
    }
}
