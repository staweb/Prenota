using System;
using System.Collections.Generic;
using System.Drawing;
using AForge.Imaging.Filters;
using Tesseract;

namespace RecogCaptcha
{ 
	public static class Decaptcha
	{
		public static void ApplyOcr(Bitmap b, ref List<string> lstWord)
		{
			string res = "";
			using (var engine = new TesseractEngine(@"tessdata", "eng", EngineMode.TesseractAndCube))
			{
				engine.SetVariable("tessedit_char_whitelist", "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz");
				//engine.SetVariable("tessedit_unrej_any_wd", true);
				engine.SetVariable("edges_min_nonhole", 5);
				engine.SetVariable("textord_heavy_nr", 1);


				using (var page = engine.Process(b, PageSegMode.SingleLine))
					res = page.GetText();
			}
			lstWord.Add(res.Replace("\n", ""));
		}
	}
}
