using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

namespace Tse_Forms.forms;

public partial class LoginControlForm : Form
{
    public LoginControlForm()
    {
        InitializeComponent();
        var fontService = DI.ServiceProvider.GetRequiredService<FontService>();
        UsernameLabel.Font = fontService.GetFont("Poppins", 10F, FontStyle.Bold);
        UsernameInput.Font = fontService.GetFont("Poppins", 9F, FontStyle.Regular);

        PasswordLabel.Font = fontService.GetFont("Poppins", 10F, FontStyle.Bold);
        PasswordInput.Font = fontService.GetFont("Poppins", 9F, FontStyle.Regular);

        // Other texts needs to be styled


    }
}
