using System;

namespace Prototipo.Models
{
    public class Carteira
    {
        public decimal StartValue { get; set; }
        public DateTime StartDate { get; set; }
        public decimal EndValue { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalProposal { get; set; }
        public decimal TotalProposalAproved { get; set; }
        public decimal TotalBocked { get; set; }
        public decimal Balance { get; set; }
        public int AmountInits { get; set; }
        public int AmountProposal { get; set; }
        public int AmountProposalAproved { get; set; }
        public int AmountProposalReproved { get; set; }
        public int AmountProposalPeding { get; set; }
        public int AmountProposalInRevision { get; set; }
    }
}