using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FitnessApp.UI.Controls
{
    public class FitnessTextblock : TextBlock
    {
        static FitnessTextblock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FitnessTextblock), new FrameworkPropertyMetadata(typeof(FitnessTextblock)));
        }
    }
}
