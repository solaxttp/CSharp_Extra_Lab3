using System;
using System.Windows.Forms;

class MyForm2 : Form
{
    Button btn;
    TextBox input;

    public MyForm2()
    {
        Text = "Додаткове завдання";
        Width = 350;
        Height = 200;

        input = new TextBox();
        input.Left = 20;
        input.Top = 20;
        input.Width = 200;
        Controls.Add(input);

        btn = new Button();
        btn.Text = "Натисни мене";
        btn.Left = 20;
        btn.Top = 60;
        btn.Click += Btn_Click;
        Controls.Add(btn);
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Ви ввели: " + input.Text);
    }
}

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MyForm2());
    }
}
