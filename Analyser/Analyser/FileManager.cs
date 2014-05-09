﻿using System.IO;
using System.Windows.Forms;
using Analyser.Properties;

namespace Analyser
{
    internal static class FileManager
    {
        internal static Stream Stream;
        internal static Parser Parser = new Parser();

        internal static ExerciseSession LoadFile(OpenFileDialog openFileDialog1)
        {
            var tempExerciseSession = new ExerciseSession();
            openFileDialog1.Title = Resources.FileManager_LoadFile_Load_cycle_training_data_;
            openFileDialog1.FileName = "";

            openFileDialog1.Filter = Resources.FileManager_LoadFile_HRM_Files___hrm;

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                var loadFile = openFileDialog1.FileName;

                Stream = File.Open(loadFile, FileMode.Open);

                tempExerciseSession = Parser.ReadDataFromStream(Stream);


                
                Stream.Close();

            }

            return tempExerciseSession;
        }
    }
}
