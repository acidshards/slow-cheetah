﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.SlowCheetah
{
    /// <summary>
    /// Interface for file tranformers
    /// </summary>
    public interface ITransformer
    {
        /// <summary>
        /// Main method that tranforms a source file accoring to a transformation file and puts it in a destination file
        /// </summary>
        /// <param name="sourcePath">Path to source file</param>
        /// <param name="transformPath">Path to tranformation file</param>
        /// <param name="destinationPath">Path to destination of transformed file</param>
        /// <returns>True if the transform succeeded</returns>
        bool Transform(string sourcePath, string transformPath, string destinationPath);

        /// <summary>
        /// Verifies if a given file is supported by this transformer
        /// </summary>
        /// <param name="filePath">The path to the file</param>
        /// <returns>True if the file can be transformed by this transformer</returns>
        bool IsFileSupported(string filePath);

        /// <summary>
        /// Creates the appropriate transform file in the given path
        /// </summary>
        /// <param name="sourcePath">Path to the source file</param>
        /// <param name="transformPath">Path to the transform file to be created</param>
        void CreateTransformFile(string sourcePath, string transformPath);
    }
}
