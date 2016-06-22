using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using mshtml;

namespace RecogCaptcha
{
	[Guid("3050f669-98b5-11cf-bb82-00aa00bdce0b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), ComVisible(true), ComImport]
	interface IHTMLElementRender
	{
		void DrawToDC([In] IntPtr hDC);
		void SetDocumentPrinter([In, MarshalAs(UnmanagedType.BStr)] string
		bstrPrinterName, [In] IntPtr hDC);
	}

	[ComImport, InterfaceType((short)1), Guid("3050F669-98B5-11CF-BB82-00AA00BDCE0B")]
	interface IHTMLElementRenderFixed
	{
		void DrawToDC(IntPtr hdc);
		void SetDocumentPrinter(string bstrPrinterName, IntPtr hdc);
	}

	public static class Getimg
	{
		public static Bitmap GetBitmap(WebBrowser web, string elementId, int posX, int posY)
		{
			if (web.Document != null)
			{
				var captchaOffSetX = GetXoffset(web.Document.GetElementById(elementId));
				var captchaOffSetY = GetYoffset(web.Document.GetElementById(elementId));

				var bitmap = new Bitmap(web.Document.Body.ScrollRectangle.Width, web.Document.Body.ScrollRectangle.Height);
				web.DrawToBitmap((Bitmap)bitmap, new Rectangle(posX, posY, web.Document.Body.ScrollRectangle.Width, web.Document.Body.ScrollRectangle.Height));
				return bitmap;
			}
			return null;
		}

		public static Bitmap CropBitmap(Bitmap bitmap, int cropX, int cropY, int cropWidth, int cropHeight)
		{
			Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
			Bitmap cropped = bitmap.Clone(rect, bitmap.PixelFormat);
			return cropped;
		}

		//Methods to get Co-ordinates Of an Element in your webbrowser
		public static int GetXoffset(HtmlElement el)
		{
			int xPos = el.OffsetRectangle.Left;
			HtmlElement tempEl = el.OffsetParent;
			while (tempEl != null)
			{
				xPos += tempEl.OffsetRectangle.Left;
				tempEl = tempEl.OffsetParent;
			}
			return xPos;
		}

		public static int GetYoffset(HtmlElement el)
		{
			int yPos = el.OffsetRectangle.Top;
			HtmlElement tempEl = el.OffsetParent;
			while (tempEl != null)
			{
				yPos += tempEl.OffsetRectangle.Top;
				tempEl = tempEl.OffsetParent;
			}
			return yPos;
		}


		public static Image CopyImageAlt(WebBrowser webBrowser, HtmlElement elem)
		{
			IHTMLImgElement img = (IHTMLImgElement)elem.DomElement;
			IHTMLElementRenderFixed render = (IHTMLElementRenderFixed)img;

			Bitmap bmp = new Bitmap(elem.OffsetRectangle.Width, elem.OffsetRectangle.Height);
			Graphics g = Graphics.FromImage(bmp);
			IntPtr hdc = g.GetHdc();
			render.DrawToDC(hdc);
			g.ReleaseHdc(hdc);
			return bmp;
		}


		public static Bitmap ApplyFilters(Image img)
		{
			Bitmap imagem = new Bitmap(img);
			imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			Erosion erosion = new Erosion();
			Dilatation dilatation = new Dilatation();
			Invert inverter = new Invert();
			ColorFiltering cor = new ColorFiltering();
			cor.Blue = new AForge.IntRange(200, 255);
			cor.Red = new AForge.IntRange(200, 255);
			cor.Green = new AForge.IntRange(200, 255);
			Opening open = new Opening();
			BlobsFiltering bc = new BlobsFiltering();
			Closing close = new Closing();
			GaussianSharpen gs = new GaussianSharpen();
			ContrastCorrection cc = new ContrastCorrection();
			bc.MinHeight = 10;
			FiltersSequence seq = new FiltersSequence(gs, inverter, open, inverter, bc, inverter, open, cc, cor, bc, inverter);
			var filteredImage = seq.Apply(imagem);
			return filteredImage;
		}
		 
		public static Bitmap ApplyFilters02(Image img)
		{
			Bitmap imagem = new Bitmap(img);
			imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

			GaussianSharpen gs = new GaussianSharpen();
			GaussianSharpen sharp = new GaussianSharpen(4, 21);
			FiltersSequence seq = new FiltersSequence(gs, sharp);

			var filteredImage = seq.Apply(imagem);
			return filteredImage;
		}

		public static Bitmap ApplyFilters03(Image img)
		{
			Bitmap image = new Bitmap(img);
			image = image.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

			GaussianSharpen gs = new GaussianSharpen();
			GaussianSharpen sharp = new GaussianSharpen(4, 21);
			ColorFiltering cor = new ColorFiltering();
			cor.Blue = new AForge.IntRange(200, 255);
			cor.Red = new AForge.IntRange(200, 255);
			cor.Green = new AForge.IntRange(200, 255);

			//FiltersSequence seq = new FiltersSequence(gs);
			//var filteredImage = seq.Apply(image);

			//var image2 = AForge.Imaging.Image.Clone(image, PixelFormat.Format8bppIndexed);
			//AForge.Imaging.Image.SetGrayscalePalette(image2);


			//SISThreshold filter = new SISThreshold();
			//filter.ApplyInPlace(image2);
			return image;
		}

		public static Bitmap ApplyFilters04(Image img)
		{
			Bitmap imagem = new Bitmap(img);
			imagem = imagem.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);

			var imgOverlayPath = AppDomain.CurrentDomain.BaseDirectory + @"img\Overlay.PNG";
			var overlay = new Bitmap(imgOverlayPath);
			Difference filter = new Difference(overlay);
			//Bitmap filteredImage = filter.Apply(imagem);
			return imagem;
		}

	}
}
