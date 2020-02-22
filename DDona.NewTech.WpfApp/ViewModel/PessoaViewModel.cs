using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.NewTech.WpfApp.ViewModel
{
    internal class PessoaViewModel : INotifyPropertyChanged
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $@"{{ {nameof(Id)} = {Id}, {nameof(NomeCompleto)} = {NomeCompleto}, {nameof(DataNascimento)} = {DataNascimento}, {nameof(Email)} = {Email}, {nameof(Telefone)} = {Telefone} }}";
        }
    }
}
