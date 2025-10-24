using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;              
using LiveChartsCore.SkiaSharpView.SKCharts;
using LiveChartsCore.SkiaSharpView.WinForms;    
using Microsoft.EntityFrameworkCore;
using MyProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace MyProject.GUI
{
    public partial class ucEvaluate : UserControl
    {
        public ucEvaluate()
        {
            InitializeComponent();
            LoadChart();

        }
        private void LoadChart()
        {
            using (var db = new AppDbContext())
            {
                var data = db.Diem
                    .GroupBy(s => s.HocKy)
                    .Select(g => new
                    {
                        HocKy = g.Key,
                        DiemTB = g.Average(x => x.DiemTrungBinh)
                    })
                    .OrderBy(x => x.HocKy)
                    .ToList();

                var labels = data.Select(x => x.HocKy).ToArray();
                var values = data.Select(x => (double)x.DiemTB).ToArray();

                var columnSeries = new ColumnSeries<double>
                {
                    Name = "Điểm trung bình (tất cả SV)",
                    Values = values
                };

                var chart = new CartesianChart
                {
                    Series = new ISeries[] { columnSeries },
                    XAxes = new Axis[]
                    {
                new Axis { Labels = labels, Name = "Học kỳ" }
                    },
                    YAxes = new Axis[]
                    {
                new Axis { Name = "Điểm", MinLimit = 0, MaxLimit = 10 }
                    },
                    Dock = DockStyle.Fill
                };

                this.Controls.Clear();
                this.Controls.Add(chart);
            }
        }

        private void ucEvaluate_Load(object sender, EventArgs e)
        {

        }
    }
}
