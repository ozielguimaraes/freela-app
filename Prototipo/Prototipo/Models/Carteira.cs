using Prototipo.ViewModels;
using System;

namespace Prototipo.Models
{
    public class Carteira : ObservableObject
    {
        decimal startValue;
        public decimal StartValue
        {
            get { return startValue; }
            set { SetProperty(ref startValue, value); }
        }

        DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { SetProperty(ref startDate, value); }
        }

        decimal endValue;
        public decimal EndValue
        {
            get { return endValue; }
            set { SetProperty(ref endValue, value); }
        }

        DateTime endDate;
        public DateTime EndDate
        {
            get { return endDate; }
            set { SetProperty(ref endDate, value); }
        }

        decimal totalProposal;
        public decimal TotalProposal
        {
            get { return totalProposal; }
            set { SetProperty(ref totalProposal, value); }
        }

        decimal totalProposalAproved;
        public decimal TotalProposalAproved
        {
            get { return totalProposalAproved; }
            set { SetProperty(ref totalProposalAproved, value); }
        }

        decimal totalBocked;
        public decimal TotalBocked
        {
            get { return totalBocked; }
            set { SetProperty(ref totalBocked, value); }
        }

        decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { SetProperty(ref balance, value); }
        }

        int amountInits;
        public int AmountInits
        {
            get { return amountInits; }
            set { SetProperty(ref amountInits, value); }
        }

        int amountProposal;
        public int AmountProposal
        {
            get { return amountProposal; }
            set { SetProperty(ref amountProposal, value); }
        }

        int amountProposalAproved;
        public int AmountProposalAproved
        {
            get { return amountProposalAproved; }
            set { SetProperty(ref amountProposalAproved, value); }
        }

        int amountProposalReproved;
        public int AmountProposalReproved
        {
            get { return amountProposalReproved; }
            set { SetProperty(ref amountProposalReproved, value); }
        }

        int amountProposalInRevision;
        public int AmountProposalInRevision
        {
            get { return amountProposalInRevision; }
            set { SetProperty(ref amountProposalInRevision, value); }
        }

        int amountProposalPending;
        public int AmountProposalPending
        {
            get { return amountProposalPending; }
            set { SetProperty(ref amountProposalPending, value); }
        }
    }
}