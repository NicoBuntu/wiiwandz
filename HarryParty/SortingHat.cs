﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WiiWandz
{
    public partial class SortingHat : Form
    {
        private List<System.Media.SoundPlayer> starting;
        private List<System.Media.SoundPlayer> choosingGryffindor;
        private List<System.Media.SoundPlayer> choosingRavenclaw;
        private List<System.Media.SoundPlayer> choosingSlytherin;
        private List<System.Media.SoundPlayer> choosingHufflepuff;
        private List<System.Media.SoundPlayer> pronouncement;
        private List<System.Media.SoundPlayer> gryffindor;
        private List<System.Media.SoundPlayer> slytherin;
        private List<System.Media.SoundPlayer> hufflepuff;
        private List<System.Media.SoundPlayer> ravenclaw;

        public SortingHat()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(HandleKeys);
            this.btnSortingHat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(HandleKeys);

            starting = new List<System.Media.SoundPlayer>();
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_ah_certo.wav"));
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_dificil.wav"));
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_muito_dificil.wav"));
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_piolhos.wav"));
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_vamos_pensar.wav"));
            starting.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_starting_kit_vejamos.wav"));

            choosingGryffindor = new List<System.Media.SoundPlayer>();
            choosingGryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_chule.wav"));
            choosingGryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_coragem.wav"));
            choosingGryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_fedendo.wav"));
            choosingGryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_outra_para_esta_crianca.wav"));
            choosingGryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_talento.wav"));

            choosingRavenclaw = new List<System.Media.SoundPlayer>();
            choosingRavenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_chule.wav"));
            choosingRavenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_esperta.wav"));
            choosingRavenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_fedendo.wav"));
            choosingRavenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_outra_para_esta_crianca.wav"));
            choosingRavenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_talento.wav"));

            choosingHufflepuff = new List<System.Media.SoundPlayer>();
            choosingHufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_chule.wav"));
            choosingHufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_fedendo.wav"));
            choosingHufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_outra_para_esta_crianca.wav"));
            choosingHufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_talento.wav"));

            choosingSlytherin = new List<System.Media.SoundPlayer>();
            choosingSlytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_chule.wav"));
            choosingSlytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_fedendo.wav"));
            choosingSlytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_pode_ser_grande.wav"));
            choosingSlytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_outra_para_esta_crianca.wav"));
            choosingSlytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_choosing_kit_talento.wav"));

            pronouncement = new List<System.Media.SoundPlayer>();
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_decidi.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_esta_ja_sei.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_esta_sera.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_este_aqui.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_hunh_ja_sei.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_ja_sei.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_sei_muito_bem.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_sera.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_vai_para.wav"));
            pronouncement.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_pronouncement_kit_vou_escolher.wav"));

            gryffindor = new List<System.Media.SoundPlayer>();
            gryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_gryffindor_1.wav"));
            gryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_gryffindor_2.wav"));
            gryffindor.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_gryffindor_3.wav"));

            slytherin = new List<System.Media.SoundPlayer>();
            slytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_slytherin_1.wav"));
            slytherin.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_slytherin_2.wav"));

            hufflepuff = new List<System.Media.SoundPlayer>();
            hufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_hufflepuff_1.wav"));
            hufflepuff.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_hufflepuff_2.wav"));

            ravenclaw = new List<System.Media.SoundPlayer>();
            ravenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_ravenclaw_1.wav"));
            ravenclaw.Add(new System.Media.SoundPlayer(@"C:\Users\CLARISSA RAMOS\Documents\GitHub\wiiwandz\HarryParty\media\sounds\sorting_hat_chosen_kit_ravenclaw_1.wav"));
        }

        private void btnSortingHat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Thread t = null;
            switch (e.KeyChar)
            {
                case '0':
                    t = new Thread(chooseRandomHouse);
                    break;
                case '1':
                    t = new Thread(chooseGryffindor);
                    break;
                case '2':
                    t = new Thread(chooseRavenclaw);
                    break;
                case '3':
                    t = new Thread(chooseHufflepuff);
                    break;
                case '4':
                    t = new Thread(chooseSlytherin);
                    break;
                case '9':
                    t = new Thread(chooseGryffindorExtended);
                    break;

            }
            if (t != null)
            {
                t.Start();
            }
            e.Handled = true;

        }
  
        private void playRandom(List<System.Media.SoundPlayer> sounds)
        {
            Random rnd = new Random();
            int toPlay = rnd.Next(0, starting.Count);
            starting.ElementAt(toPlay).PlaySync();

            toPlay = rnd.Next(0, sounds.Count);
            sounds.ElementAt(toPlay).PlaySync();

            toPlay = rnd.Next(0, pronouncement.Count);
            pronouncement.ElementAt(toPlay).PlaySync();
        }


        private void chooseRandomHouse()
        {
            Random rnd = new Random();
            int toPlay = rnd.Next(0, 4);

            switch (toPlay)
            {
                case 0:
                    chooseGryffindor();
                    break;
                case 1:
                    chooseHufflepuff();
                    break;
                case 2:
                    chooseRavenclaw();
                    break;
                case 3:
                    chooseSlytherin();
                    break;

            }
        }

        private void chooseGryffindorExtended()
        {
            playRandom(choosingGryffindor);

            this.BackgroundImage = Properties.Resources.sorting_hat_bg_gryffindor;

            Random rnd = new Random();
            int toPlay = rnd.Next(0, gryffindor.Count);
            gryffindor.ElementAt(toPlay).PlaySync();

            reset();
        }

        private void chooseSlytherin()
        {
            playRandom(choosingSlytherin);

            this.BackgroundImage = Properties.Resources.sorting_hat_bg_slytherin;

            Random rnd = new Random();
            int toPlay = rnd.Next(0, slytherin.Count);
            slytherin.ElementAt(toPlay).PlaySync();

            reset();
        }

        private void chooseHufflepuff()
        {
            playRandom(choosingHufflepuff);

            this.BackgroundImage = Properties.Resources.sorting_hat_bg_hufflepuff;

            Random rnd = new Random();
            int toPlay = rnd.Next(0, hufflepuff.Count);
            hufflepuff.ElementAt(toPlay).PlaySync();

            reset();
        }

        private void chooseRavenclaw()
        {
            playRandom(choosingRavenclaw);

            this.BackgroundImage = Properties.Resources.sorting_hat_bg_ravenclaw;

            Random rnd = new Random();
            int toPlay = rnd.Next(0, ravenclaw.Count);
            ravenclaw.ElementAt(toPlay).PlaySync();

            reset();
        }

        private void chooseGryffindor()
        {
            playRandom(choosingGryffindor);

            this.BackgroundImage = Properties.Resources.sorting_hat_bg_gryffindor;

            Random rnd = new Random();
            int toPlay = rnd.Next(0, gryffindor.Count);
            gryffindor.ElementAt(toPlay).PlaySync();

            reset();
        }

        private void reset()
        {
            this.BackgroundImage = Properties.Resources.hogwarts_logo_wood;
        }
    }
}
