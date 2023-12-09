using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding_Session_Demo.Converters
{
    public class MarksToGrade : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double marks = (double)value;
            if (marks > 90) return "A+ (Excellent)";
            else if (marks > 80) return "A (Very Good)";
            else if (marks > 70) return "B+ (Good)";
            else if (marks > 60) return "B (Satisfactory)";
            else if (marks > 50) return "C (Average)";
            else if (marks > 40) return "D (Pass)";
            else return "F (Fail)";


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
