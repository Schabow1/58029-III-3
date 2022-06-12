
namespace _58029_III_3
{
    partial class SC_58029_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sc_58029_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sc_58029_Timer
            // 
            this.sc_58029_Timer.Tick += new System.EventHandler(this.sc_58029_Timer_Tick);
            // 
            // SC_58029_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Name = "SC_58029_Form";
            this.Text = "58029-III_3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sc_58029_Timer;
    }
}

