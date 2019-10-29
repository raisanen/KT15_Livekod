using DataLogik.Services;
using KT15_Livekod.Services;
using System;

namespace KT15_Livekod {
    class Program {
        private static readonly IDataService<string[,]> _dataService;
        private static readonly IPresentationService<string[,]> _presentationService;

        static Program() {
            _dataService = new RealDataService("artwork.json");
            _presentationService = new PresentationService();
        }

        static void Main(string[] args) {
            Console.CursorVisible = false; // ställer till en massa problem annars

            var artwork = _dataService.Load();

            _presentationService.Output(artwork, Console.OpenStandardOutput());
            _dataService.Save(artwork);
            Console.ReadKey();
        }
    }
}
