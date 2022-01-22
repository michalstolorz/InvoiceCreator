using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InvoiceCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables

        String productName1;
        String quantity1;
        String price1;

        String productName2;
        String quantity2;
        String price2;

        String productName3;
        String quantity3;
        String price3;

        String productName4;
        String quantity4;
        String price4;

        String productName5;
        String quantity5;
        String price5;

        String productName6;
        String quantity6;
        String price6;

        String productName7;
        String quantity7;
        String price7;

        String productName8;
        String quantity8;
        String price8;

        String productName9;
        String quantity9;
        String price9;

        String productName10;
        String quantity10;
        String price10;

        String productName11;
        String quantity11;
        String price11;

        String productName12;
        String quantity12;
        String price12;

        String customerName;
        String customerEmail;
        String customerPhoneNumber;
        String tax;
        String shippingCost;
        String customerCityPostalCode;
        String customerStreetNumber;
        String customerNIP;
        String customerREGON;

        #endregion Variables

        #region Property

        private void TextBox_CustomerName(object sender, TextChangedEventArgs e)
        {
            customerName = customerNameTextBox.Text.ToString();
        }

        private void TextBox_CustomerEmail(object sender, TextChangedEventArgs e)
        {
            customerEmail = customerEmailTextBox.Text.ToString();
        }

        private void TextBox_CustomerPhoneNumber(object sender, TextChangedEventArgs e)
        {
            customerPhoneNumber = customerPhoneNumberTextBox.Text.ToString();
        }

        private void TextBox_Tax(object sender, TextChangedEventArgs e)
        {
            tax = taxTextBox.Text.ToString();
        }

        private void TextBox_ShippingCost(object sender, TextChangedEventArgs e)
        {
            shippingCost = shippingCostTextBox.Text.ToString();
        }

        private void TextBox_CustomerCityPostalCode(object sender, TextChangedEventArgs e)
        {
            customerCityPostalCode = customerCityPostalCodeTextBox.Text.ToString();
        }

        private void TextBox_CustomerStreetNumber(object sender, TextChangedEventArgs e)
        {
            customerStreetNumber = customerStreetNumberTextBox.Text.ToString();
        }

        private void TextBox_NIP(object sender, TextChangedEventArgs e)
        {
            customerNIP = customerNIPTextBox.Text.ToString();
        }

        private void TextBox_REGON(object sender, TextChangedEventArgs e)
        {
            customerREGON = customerREGONTextBox.Text.ToString();
        }

        private void TextBox_productName1(object sender, TextChangedEventArgs e)
        {
            productName1 = productName1TextBox.Text.ToString();
        }

        private void TextBox_quantity1(object sender, TextChangedEventArgs e)
        {
            quantity1 = quantity1TextBox.Text.ToString();
        }

        private void TextBox_price1(object sender, TextChangedEventArgs e)
        {
            price1 = price1TextBox.Text.ToString();
        }

        private void TextBox_productName2(object sender, TextChangedEventArgs e)
        {
            productName2 = productName2TextBox.Text.ToString();
        }

        private void TextBox_quantity2(object sender, TextChangedEventArgs e)
        {
            quantity2 = quantity2TextBox.Text.ToString();
        }

        private void TextBox_price2(object sender, TextChangedEventArgs e)
        {
            price2 = price2TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName3(object sender, TextChangedEventArgs e)
        {
            productName3 = productName3TextBox.Text.ToString();
        }

        private void TextBox_quantity3(object sender, TextChangedEventArgs e)
        {
            quantity3 = quantity3TextBox.Text.ToString();
        }

        private void TextBox_price3(object sender, TextChangedEventArgs e)
        {
            price3 = price3TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName4(object sender, TextChangedEventArgs e)
        {
            productName4 = productName4TextBox.Text.ToString();
        }

        private void TextBox_quantity4(object sender, TextChangedEventArgs e)
        {
            quantity4 = quantity4TextBox.Text.ToString();
        }

        private void TextBox_price4(object sender, TextChangedEventArgs e)
        {
            price4 = price4TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName5(object sender, TextChangedEventArgs e)
        {
            productName5 = productName5TextBox.Text.ToString();
        }

        private void TextBox_quantity5(object sender, TextChangedEventArgs e)
        {
            quantity5 = quantity5TextBox.Text.ToString();
        }

        private void TextBox_price5(object sender, TextChangedEventArgs e)
        {
            price5 = price5TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName6(object sender, TextChangedEventArgs e)
        {
            productName6 = productName6TextBox.Text.ToString();
        }

        private void TextBox_quantity6(object sender, TextChangedEventArgs e)
        {
            quantity6 = quantity6TextBox.Text.ToString();
        }

        private void TextBox_price6(object sender, TextChangedEventArgs e)
        {
            price6 = price6TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName7(object sender, TextChangedEventArgs e)
        {
            productName7 = productName7TextBox.Text.ToString();
        }

        private void TextBox_quantity7(object sender, TextChangedEventArgs e)
        {
            quantity7 = quantity7TextBox.Text.ToString();
        }

        private void TextBox_price7(object sender, TextChangedEventArgs e)
        {
            price7 = price7TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName8(object sender, TextChangedEventArgs e)
        {
            productName8 = productName8TextBox.Text.ToString();
        }

        private void TextBox_quantity8(object sender, TextChangedEventArgs e)
        {
            quantity8 = quantity8TextBox.Text.ToString();
        }

        private void TextBox_price8(object sender, TextChangedEventArgs e)
        {
            price8 = price8TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName9(object sender, TextChangedEventArgs e)
        {
            productName9 = productName9TextBox.Text.ToString();
        }

        private void TextBox_quantity9(object sender, TextChangedEventArgs e)
        {
            quantity9 = quantity9TextBox.Text.ToString();
        }

        private void TextBox_price9(object sender, TextChangedEventArgs e)
        {
            price9 = price9TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName10(object sender, TextChangedEventArgs e)
        {
            productName10 = productName10TextBox.Text.ToString();
        }

        private void TextBox_quantity10(object sender, TextChangedEventArgs e)
        {
            quantity10 = quantity10TextBox.Text.ToString();
        }

        private void TextBox_price10(object sender, TextChangedEventArgs e)
        {
            price10 = price10TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName11(object sender, TextChangedEventArgs e)
        {
            productName11 = productName11TextBox.Text.ToString();
        }

        private void TextBox_quantity11(object sender, TextChangedEventArgs e)
        {
            quantity11 = quantity11TextBox.Text.ToString();
        }

        private void TextBox_price11(object sender, TextChangedEventArgs e)
        {
            price11 = price11TextBox.Text.ToString();
        }

        ////////////////

        private void TextBox_productName12(object sender, TextChangedEventArgs e)
        {
            productName12 = productName12TextBox.Text.ToString();
        }

        private void TextBox_quantity12(object sender, TextChangedEventArgs e)
        {
            quantity12 = quantity12TextBox.Text.ToString();
        }

        private void TextBox_price12(object sender, TextChangedEventArgs e)
        {
            price12 = price12TextBox.Text.ToString();
        }

        ////////////////
        #endregion Property

        public MainWindow()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTY2NTA0QDMxMzkyZTM0MmUzMEN3RjVDcEVYSkRkWm8vN2xucXFFWHhML3lSc29yZk5zL2tPRkVoMW5WOGM9");
        }

        #region StringList
        private List<string> CreateProductNamesList()
        {
            return new List<string>()
            {
                productName1,
                productName2,
                productName3,
                productName4,
                productName5,
                productName6,
                productName7,
                productName8,
                productName9,
                productName10,
                productName11,
                productName12
            };
        }

        private List<string> CreateQuantitiesList()
        {
            return new List<string>()
            {
                quantity1,
                quantity2,
                quantity3,
                quantity4,
                quantity5,
                quantity6,
                quantity7,
                quantity8,
                quantity9,
                quantity10,
                quantity11,
                quantity12
            };
        }

        private List<string> CreatePricesList()
        {
            return new List<string>()
            {
                price1,
                price2,
                price3,
                price4,
                price5,
                price6,
                price7,
                price8,
                price9,
                price10,
                price11,
                price12
            };
        }

        private List<string> ParseProductNamesList(List<string> stringList)
        {
            var list = new List<string>();

            foreach (var s in stringList)
            {
                if (s == null)
                    break;

                list.Add(s);
            }

            return list;
        }

        #endregion StringList

        #region DecimalList

        private List<decimal> ParseQuantitiesListToDecimal(List<string> stringList)
        {
            var list = new List<decimal>();

            foreach (var s in stringList)
            {
                if (s == null)
                    break;

                list.Add(Decimal.Parse(s));
            }

            return list;
        }

        private List<decimal> ParsePriceListToDecimal(List<string> stringList)
        {
            var list = new List<decimal>();

            foreach (var s in stringList)
            {
                if (s == null)
                    break;

                list.Add(Decimal.Parse(s));
            }

            return list;
        }

        #endregion

        private void Button_CreateInvoiceClick(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> productNamesList = CreateProductNamesList();
                List<string> quantitiesList = CreateQuantitiesList();
                List<string> pricesList = CreatePricesList();

                List<string> parsedProductNamesList = ParseProductNamesList(productNamesList);
                List<decimal> decimalQuantitiesList = ParseQuantitiesListToDecimal(quantitiesList);
                List<decimal> decimalPricesList = ParsePriceListToDecimal(pricesList);

                PdfDocument document = new PdfDocument();
                //Create border color.
                PdfColor borderColor = new PdfColor(Color.FromArgb(255, 142, 170, 219));
                PdfBrush lightBlueBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 91, 126, 215)));

                PdfBrush darkBlueBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 65, 104, 209)));

                PdfBrush whiteBrush = new PdfSolidBrush(new PdfColor(Color.FromArgb(255, 255, 255, 255)));
                PdfPen borderPen = new PdfPen(borderColor, 1f);

                string currentDirectory = Directory.GetCurrentDirectory();
                string path = System.IO.Path.Combine(currentDirectory, "arial.ttf");
                Stream fontStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);

                //Create TrueType font.
                PdfTrueTypeFont headerFont = new PdfTrueTypeFont(fontStream, 30, PdfFontStyle.Regular);
                PdfTrueTypeFont arialRegularFont = new PdfTrueTypeFont(fontStream, 9, PdfFontStyle.Regular);
                PdfTrueTypeFont arialBoldFont = new PdfTrueTypeFont(fontStream, 11, PdfFontStyle.Regular);

                const float margin = 30;
                const float lineSpace = 7;
                const float headerHeight = 90;

                //Add page to the PDF.
                PdfPage page = document.Pages.Add();

                PdfGraphics graphics = page.Graphics;

                //Get the page width and height.
                float pageWidth = page.GetClientSize().Width;
                float pageHeight = page.GetClientSize().Height;
                //Draw page border
                graphics.DrawRectangle(borderPen, new RectangleF(0, 0, pageWidth, pageHeight));

                //Fill the header with light Brush.
                graphics.DrawRectangle(lightBlueBrush, new RectangleF(0, 0, pageWidth, headerHeight));

                RectangleF headerAmountBounds = new RectangleF(400, 0, pageWidth - 400, headerHeight);

                graphics.DrawString("FAKTURA", headerFont, whiteBrush, new PointF(margin, headerAmountBounds.Height / 3));

                graphics.DrawRectangle(darkBlueBrush, headerAmountBounds);

                graphics.DrawString("Kwota", arialRegularFont, whiteBrush, headerAmountBounds, new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle));

                PdfTextElement textElement = new PdfTextElement("", arialRegularFont);

                PdfLayoutResult layoutResult = textElement.Draw(page, new PointF(headerAmountBounds.X - (margin + 40), 120));

                textElement.Text = "Data wystawienia: " + DateTime.Now.ToString("dddd dd, MMMM yyyy") + "\n" + "Data sprzedaży: " + DateTime.Now.ToString("dddd dd, MMMM yyyy");
                textElement.Draw(page, new PointF(layoutResult.Bounds.X - 30, layoutResult.Bounds.Bottom + lineSpace));

                textElement.Text = "Dane wysyłki:";
                layoutResult = textElement.Draw(page, new PointF(margin + 130, 120));

                textElement.Text = customerCityPostalCode;
                layoutResult = textElement.Draw(page, new PointF(margin + 130, layoutResult.Bounds.Bottom + lineSpace));

                textElement.Text = customerStreetNumber;
                layoutResult = textElement.Draw(page, new PointF(margin + 130, layoutResult.Bounds.Bottom + lineSpace));

                if (!String.IsNullOrEmpty(customerNIP))
                {
                    textElement.Text = "NIP: " + customerNIP;
                    layoutResult = textElement.Draw(page, new PointF(margin + 130, layoutResult.Bounds.Bottom + lineSpace));
                }

                if (!String.IsNullOrEmpty(customerREGON))
                {
                    textElement.Text = "REGON: " + customerREGON;
                    layoutResult = textElement.Draw(page, new PointF(margin + 130, layoutResult.Bounds.Bottom + lineSpace));
                }

                textElement.Text = "Nabywca:";
                layoutResult = textElement.Draw(page, new PointF(margin, 120));

                textElement.Text = customerName;
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
                textElement.Text = customerEmail;
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
                textElement.Text = customerPhoneNumber;
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));

                PdfGrid grid = new PdfGrid();
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Lp.");
                dataTable.Columns.Add("Nazwa produktu");
                dataTable.Columns.Add("Ilość");
                dataTable.Columns.Add("Cena brutto");
                dataTable.Columns.Add("Stawka VAT");
                dataTable.Columns.Add("Wartość netto");
                dataTable.Columns.Add("Kwota VAT");
                dataTable.Columns.Add("Wartość brutto");

                decimal TaxNetValue = (100 - Decimal.Parse(tax)) / 100;
                decimal VATValue = Decimal.Parse(tax) / 100;
                const string PLN = " PLN";
                decimal totalAmount = 0;
                int i;

                for (i = 0; i < parsedProductNamesList.Count(); i++)
                {
                    dataTable.Rows.Add(new object[] { i + 1,
                                                  parsedProductNamesList[i],
                                                  quantitiesList[i] + " szt",
                                                  pricesList[i] + PLN,
                                                  tax + "%",
                                                  Math.Round(decimalPricesList[i] * TaxNetValue * decimalQuantitiesList[i], 2).ToString() + PLN,
                                                  Math.Round(decimalPricesList[i] * VATValue * decimalQuantitiesList[i], 2).ToString() + PLN,
                                                  Math.Round(decimalPricesList[i] * decimalQuantitiesList[i], 2).ToString() + PLN });

                    totalAmount += Math.Round(decimalPricesList[i] * decimalQuantitiesList[i], 2);
                }

                if (shippingCost == "0")
                {
                    dataTable.Rows.Add(new object[] { i + 1,
                                                  "Koszty wysyłki",
                                                  "1 szt",
                                                  shippingCost + PLN,
                                                  tax + "%",
                                                  shippingCost + PLN,
                                                  shippingCost + PLN,
                                                  shippingCost + PLN });

                }
                else
                {
                    dataTable.Rows.Add(new object[] { i + 1,
                                                  "Koszty wysyłki",
                                                  "1 szt",
                                                  shippingCost + PLN,
                                                  tax + "%",
                                                  Math.Round(Decimal.Parse(shippingCost) * TaxNetValue, 2).ToString() + PLN,
                                                  Math.Round(Decimal.Parse(shippingCost) * VATValue, 2).ToString() + PLN,
                                                  shippingCost + PLN });
                }

                grid.DataSource = dataTable;

                grid.Columns[0].Width = 30;
                grid.Columns[1].Width = 120;
                grid.Columns[2].Width = 40;
                grid.Columns[3].Width = 70;
                grid.Columns[4].Width = 40;
                grid.Columns[5].Width = 80;
                grid.Columns[6].Width = 70;
                grid.Columns[7].Width = 65;

                grid.Style.Font = arialRegularFont;
                grid.Style.CellPadding.All = 5;

                grid.ApplyBuiltinStyle(PdfGridBuiltinStyle.ListTable4Accent5);

                layoutResult = grid.Draw(page, new PointF(0, layoutResult.Bounds.Bottom + 40));

                textElement.Text = "Suma: ";
                textElement.Font = arialBoldFont;
                layoutResult = textElement.Draw(page, new PointF(headerAmountBounds.X - 40, layoutResult.Bounds.Bottom + lineSpace));

                totalAmount += Decimal.Parse(shippingCost);

                textElement.Text = totalAmount.ToString() + " PLN";
                layoutResult = textElement.Draw(page, new PointF(layoutResult.Bounds.Right + 4, layoutResult.Bounds.Y));

                graphics.DrawString(totalAmount.ToString() + " PLN", arialBoldFont, whiteBrush, new RectangleF(400, lineSpace, pageWidth - 400, headerHeight + 15), new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle));

                borderPen.DashStyle = PdfDashStyle.Custom;
                borderPen.DashPattern = new float[] { 3, 3 };

                path = System.IO.Path.Combine(currentDirectory, "KonfiguracjaDanych.txt");
                string[] ownerData = System.IO.File.ReadAllLines(path);

                PdfLine line = new PdfLine(borderPen, new PointF(0, 0), new PointF(pageWidth, 0));
                layoutResult = line.Draw(page, new PointF(0, pageHeight - 110));

                FileStream imageFileStream = new FileStream(currentDirectory + @"\logo.jpg", FileMode.Open);
                PdfBitmap image = new PdfBitmap(imageFileStream);

                textElement.Text = ownerData[0];
                textElement.Font = arialRegularFont;
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + (lineSpace * 2)));
                textElement.Text = ownerData[1] + "\n" +
                    ownerData[2] + "\n" +
                    ownerData[3] + "\n" +
                    ownerData[4];
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));
                textElement.Text = "Pytania? Email: " + ownerData[5] + "\nTel: " + ownerData[6] + "; " + ownerData[7];
                layoutResult = textElement.Draw(page, new PointF(margin, layoutResult.Bounds.Bottom + lineSpace));

                path = System.IO.Path.Combine(currentDirectory, "NumerFaktury.txt");
                var invoiceNumber = System.IO.File.ReadAllLines(path)[0];

                graphics.DrawImage(image, new PointF(layoutResult.Bounds.Right + 39, layoutResult.Bounds.Bottom - 92));

                var fileName = "Faktura " + customerName + invoiceNumber + ".pdf";
                FileStream fileStream = new FileStream(currentDirectory + @"\Faktury\" + fileName, FileMode.CreateNew, FileAccess.ReadWrite);
                document.Save(fileStream);
                document.Close(true);

                fileStream.Close();
                fontStream.Close();
                imageFileStream.Close();

                string newInvoiceNumber = (int.Parse(invoiceNumber) + 1).ToString();
                File.WriteAllText(path, newInvoiceNumber);

                MessageBox.Show("Faktura wygenerowana");
            }
            catch (Exception)
            {
                MessageBox.Show("Błędne dane/Brak danych.");
            }
        }
    }
}
