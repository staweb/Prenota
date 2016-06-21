using System;
using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;
using Tesseract;

namespace RecogCaptcha
{
	public class FilterSettings
	{
		public FilterSettings()
		{
		}

		public bool GrayScale { get; set; }
		public bool AdaptiveSmoothing { get; set; }
		public bool BilateralSmoothing { get; set; }
		public bool BinaryDilatation3x3 { get; set; }
		public bool BinaryErosion3x3 { get; set; }
		public bool BlobsFiltering { get; set; }
		public bool Blur { get; set; }

	}
}
