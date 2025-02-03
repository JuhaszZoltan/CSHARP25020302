namespace UtasszallitokGUI;

public partial class MachSzamForm : Form
{
    public MachSzamForm()
    {
        InitializeComponent();
        btnSzamol.Click += BtnSzamol_Click;
    }

    private void BtnSzamol_Click(object? sender, EventArgs e)
    {
        double qc, p0;

        try
        {
            qc = double.Parse(tbxTorlo.Text.Replace('.', ','));
            p0 = double.Parse(tbxStatikus.Text.Replace('.', ','));
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message);
            return;
        }
        double ma = Math.Sqrt(5 * (Math.Pow((qc / p0) + 1, 2d/7) -1));

        if (ma < 1) lsbEredmenyek.Items.Add($"qc={qc} p0={p0} Ma={ma}");
        else lsbEredmenyek.Items.Add($"qc={qc} p0={p0} NEM SZUBSZONIKUS");
    }
}
