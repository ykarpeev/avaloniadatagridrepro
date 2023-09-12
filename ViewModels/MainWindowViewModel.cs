using Avalonia.Collections;
using System.Collections.Generic;

namespace datagridrepro.ViewModels
{
    public class StatusItem
    {
        public StatusItem(int code, string color, string message)
        {
            Code = code;
            Color = color;
            Message = message;
        }

        public int Code { get; init; }

        public string Color { get; init; }

        public string Message { get; init; }
    }
    public partial class MainWindowViewModel : ViewModelBase
    {
        public StatusItem SelectedItem { get; set; }
        public List<string> ColorsSource { get; }

        public AvaloniaList<StatusItem> StatusCodes { get; }
        public MainWindowViewModel()
        {
            this.ColorsSource = new List<string>() { "White", "Blue", "Red" };
            this.StatusCodes = new AvaloniaList<StatusItem>
            {
                new StatusItem(1, "White", "Test"),
                new StatusItem(2, "Blue", "Test2"),
                new StatusItem(3, "Red", "Test3")
            };

        }
        public string Greeting => "Welcome to Avalonia!";
    }
    }

