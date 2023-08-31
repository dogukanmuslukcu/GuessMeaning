using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace GuessMeaning;

public partial class Form1 : Form
{
    Excel.Application excelApp;
    Excel.Workbook workbook;
    Excel.Worksheet worksheet;
    int currentRow = 2; // Ýlk kelime verilerin olduðu satýrdan baþla

    public Form1()
    {
        InitializeComponent();
        excelApp = new Excel.Application();
        workbook = excelApp.Workbooks.Open("C:\\Users\\doðukan\\Desktop\\Doðukan\\English\\DailyEnglishWords.xlsx"); // Excel dosyasýný yükle
        worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Ýlk çalýþma sayfasýný seç
    }

    private void FormGame_Load(object sender, EventArgs e)
    {
        ShowNextWord();
    }

    private void ShowNextWord()
    {
        Excel.Range range = (Excel.Range)worksheet.Cells[currentRow, 1];
        string? nextWord = range.Value != null ? range.Value.ToString() : string.Empty;
        labelWord.Text = nextWord;
        txtMeaning.Text = "";
    }

    private void btnCheck_Click(object sender, EventArgs e)
    {
        string enteredMeaning = txtMeaning.Text.Trim().ToLower().Replace(" ","");
        Excel.Range range = (Excel.Range)worksheet.Cells[currentRow, 2];
        string correctMeaning = range.Value != null ? range.Value.ToString().ToLower().Replace(" ","") : string.Empty;

        if (enteredMeaning == correctMeaning)
        {
            MessageBox.Show("Doðru!");
        }
        else
        {
            MessageBox.Show($"Yanlýþ! Doðru anlam: {correctMeaning}");
        }
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
        currentRow++;
        if (currentRow > worksheet.UsedRange.Rows.Count)
        {
            MessageBox.Show("Tüm kelimeleri bitirdiniz.");
            Close();
        }
        else
        {
            ShowNextWord();
        }
    }

   

    private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
    {
        workbook.Close(false);
        excelApp.Quit();
    }


}