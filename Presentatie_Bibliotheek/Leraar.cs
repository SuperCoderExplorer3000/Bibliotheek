﻿using Bibliotheek.business;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentatie_Bibliotheek
{
    public partial class Leeraar : Form
    {
        public Leeraar()
        {
            InitializeComponent();
        }
        private Controller _controller;
        private void Leeraar_Load(object sender, EventArgs e)
        {
            try
            {
                _controller = new Controller();
                lbOverzicht.DataSource = _controller.GetBoeken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoekToevoegen_Click(object sender, EventArgs e)
        {
            frmVoegToe frmAdd = new frmVoegToe();

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                lbOverzicht.DataSource = null;
                lbOverzicht.DataSource = _controller.GetBoeken;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                _controller = new Controller();
                lbOverzicht.DataSource = _controller.GetBoeken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate updateForm = new frmUpdate();
            updateForm.ShowDialog();

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            //input box om het boekID te vragen
            string input = Interaction.InputBox("Voer het BoekID in dat u wilt verwijderen:", "Boek Verwijderen", "", -1, -1);
            //boek verwijderen via de controller
            if (int.TryParse(input, out int boekID))
            {
                try
                {
                    _controller.DeleteBoek(boekID);
                    lbOverzicht.DataSource = null;
                    lbOverzicht.DataSource = _controller.GetBoeken;
                    MessageBox.Show("Boek succesvol verwijderd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Voer een geldig BoekID in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGebruikers_Click(object sender, EventArgs e)
        {
            //open het gebruikersbeheer formulier
            frmGebruikers gebruikersForm = new frmGebruikers();
            gebruikersForm.ShowDialog();

        }

        private void btnLogUit_Click(object sender, EventArgs e)
        {
            //sluit het huidige formulier en gaat terug naar het inlogscherm
            this.Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // Filter de lijst van boeken op basis van de zoekterm
            string searchTerm = tbSearch.Text.ToLower();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                lbOverzicht.DataSource = _controller.GetBoeken; // Toon alle boeken als de zoekterm leeg is
            }
            else
            {
                var boekengefilterd = _controller.GetBoeken
                    .Where(b => b.Titel.ToLower().Contains(searchTerm) ||
                                b.Auteur.ToLower().Contains(searchTerm) ||
                                b.Uitgever.ToLower().Contains(searchTerm) ||
                                b.Taal.ToLower().Contains(searchTerm))
                    .ToList();
                lbOverzicht.DataSource = boekengefilterd; // Toon de gefilterde lijst
            }
        }
    }
}
