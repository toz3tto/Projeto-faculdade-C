using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.Logging;

namespace Pacientes
{
    public partial class FormExercicios : Form
    {
        private List<string> listaExercicios;
        private Dictionary<string, List<string>> protocolos;

        // Definindo o nome e CREFITO fixos da fisioterapeuta
        private string nomeFisioterapeuta = "Nikoly Bittencourt";
        private string crefitoFisioterapeuta = "CREFITO 295076-F";

        public FormExercicios()
        {
            InitializeComponent();
            listaExercicios = new List<string>();
            CarregarProtocolos();
            CarregarOpcoesComboBox();
        }

        private void CarregarProtocolos()
        {
            protocolos = new Dictionary<string, List<string>>();

            protocolos["Reabilitação Abdominal"] = new List<string>
                { "Respiração completa por 1 minuto: respire com os dentes serrados, soltando o ar entre os dentes. Realize quantas vezes conseguir dentro desse 1 minuto.",
                  "5 repetições do preparatório de ponte, realizando 2 séries: deite-se com os joelhos dobrados, mãos ao lado do corpo e realize a respiração, mantendo o queixo no peito.",
                  "2 repetições de 20 segundos de ponte isométrica: faça a ponte e mantenha o bumbum elevado por 20 segundos. Se a expiração terminar antes dos 20 segundos, inspire e repita.",
                  "10 repetições de Deadbug (perna e braço unilateral): mantenha os joelhos a 90°, cotovelos esticados para cima. Abaixe a perna direita enquanto o braço esquerdo vai para trás, alternando os lados.",
                  "10 repetições de braço e perna do mesmo lado: deite-se com os joelhos a 90° e cotovelos esticados. Na expiração, estenda a perna direita e o braço direito. Em seguida, alterne.",
                  "5 repetições de adução com bola entre os joelhos: faça a ponte, lembrando-se de apertar a bola, ativando o abdômen para dentro e para cima, com o queixo no peito."
                };
            protocolos["Assoalho Pelvico - 3s "] = new List<string> 
                { "TREINO DE FORTALECIMENTO DO ASSOALHO PÉLVICO:",
                  "Contraia o assoalho pélvico e segure por 3 segundos.",
                  "Relaxe por 3 segundos.",
                  "Após realizar 3 contrações e relaxamentos, descanse por 45 segundos.",
                  "EM SEGUIDA, REPITA TUDO NOVAMENTE:",
                  "Contraia e mantenha por 3 segundos.",
                  "Relaxe por 3 segundos.",
                  "Após realizar as 3 contrações, descanse por 45 segundos.",
                  "Repita mais uma vez as 3 contrações e os 3 relaxamentos, e descanse por 1 minuto.",
                  "Em seguida, repita tudo novamente (contraindo 3 vezes e relaxando 3 vezes, por 3 repetições).",
                  "Realize esse treino por 2 semanas.",
                };
            protocolos["Assoalho Pelvico - 5s "] = new List<string>
                { "TREINO DE FORTALECIMENTO DO ASSOALHO PÉLVICO:",
                  "Contraia o assoalho pélvico e segure por 5 segundos.",
                  "Relaxe por 5 segundos.",
                  "Após realizar 5 contrações e relaxamentos, descanse por 45 segundos.",
                  "EM SEGUIDA, REPITA TUDO NOVAMENTE:",
                  "Contraia e mantenha por 5 segundos.",
                  "Relaxe por 5 segundos.",
                  "Após realizar as 5 contrações, descanse por 45 segundos.",
                  "Repita mais uma vez as 5 contrações e os 5 relaxamentos, e descanse por 1 minuto.",
                  "Em seguida, repita tudo novamente (contraindo 5 vezes e relaxando 5 vezes, por 3 repetições).",
                  "Realize esse treino por 2 semanas.",
                };
            protocolos["Treinamento Domiciliar 01"] = new List<string> { "Realizar 3 séries de 3 exercícios","Contração: Contraia 100% da força muscular, depois relaxe 30%. Em seguida, relaxe mais 50% e, por fim, relaxe completamente (100%).",
                "Relaxamento: Descanse por 10 segundos e repita 3 vezes." };
            protocolos["Treinamento Domiciliar 02"] = new List<string> { "Realizar 3 séries de 3 exercícios","Contração: Contraia 100% da força muscular, depois relaxe 50%. Em seguida, relaxe mais 50% e, por fim, relaxe completamente (100%).",
                "Relaxamento: Descanse por 10 segundos e repita 3 vezes." };
            protocolos["Treinamento Domiciliar 03"] = new List<string> { "Realizar 3 séries de 3 exercícios", "Contração: Contraia 30%, depois 50% e, em seguida, 100% da força muscular.",
                "Após isso, relaxe 30%, depois 50%","Observação:Repita 3 vezes, descanse por 10 segundos e repita novamente mais 3 vezes." };
        }

        private void CarregarOpcoesComboBox()
        {
            foreach (var protocolo in protocolos.Keys)
            {
                comboBox1.Items.Add(protocolo);
            }
        }

        //melhorar essa função.

        /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string protocoloSelecionado = comboBox1.SelectedItem.ToString();

            listaExercicios.Clear();
            lstExercicios.Items.Clear();

            if (protocolos.ContainsKey(protocoloSelecionado))
            {
                listaExercicios.AddRange(protocolos[protocoloSelecionado]);
                foreach (var exercicio in protocolos[protocoloSelecionado])
                {
                    lstExercicios.Items.Add(exercicio);
                }
            }
        }*/

        //Funçao do botão melhorada.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return; // Verifica se algum item foi selecionado

            string protocoloSelecionado = comboBox1.SelectedItem.ToString();

            listaExercicios.Clear();
            lstExercicios.Items.Clear();

            // Verifica se o protocolo existe no dicionário e atualiza a lista de exercícios
            if (protocolos.TryGetValue(protocoloSelecionado, out var exercicios))
            {
                listaExercicios.AddRange(exercicios);

                foreach (var exercicio in exercicios)
                {
                    lstExercicios.Items.Add(exercicio);
                }
            }
        }

        private void btnGerarPDF_Click_1(object sender, EventArgs e)
        {
            if (listaExercicios.Count == 0)
            {
                MessageBox.Show("Não há exercícios para gerar o PDF.");
                return;
            }

            // Atribuindo o nome do paciente dentro do método, como antes
            string nomePaciente = txtNomePaciente.Text.Trim();

            if (string.IsNullOrEmpty(nomePaciente))
            {
                MessageBox.Show("Por favor, preencha o nome do paciente.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Salvar Lista de Exercícios"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;

                Document doc = new Document(PageSize.A4, 40f, 40f, 50f, 50f);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));

                // Criando a classe de evento para o rodapé
                writer.PageEvent = new RodapePdf(nomePaciente, nomeFisioterapeuta, crefitoFisioterapeuta);

                doc.Open();

                string protocoloSelecionado = comboBox1.SelectedItem.ToString();



                if (protocoloSelecionado == "Treinamento Domiciliar 01" || protocoloSelecionado == "Treinamento Domiciliar 02" || protocoloSelecionado == "Treinamento Domiciliar 03")
                {
                    // Layout personalizado para protocolos C e D
                    AdicionarLayoutPersonalizadoCD(doc, nomePaciente);
                }
                else
                {

                    // Adicionando a logo no cabeçalho
                    try
                    {
                        // Caminho da logo
                        string caminhoLogo = @"C:\Dev\cSharp\ProjetoOriginal\logos\logo.png"; // Caminho completo da logo

                        // Carregando a imagem da logo
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);

                        // Definindo alinhamento e escala
                        float larguraPagina = doc.PageSize.Width - 80f; // Largura total disponível após as margens (40 unidades de cada lado)
                        logo.ScaleToFit(larguraPagina, float.MaxValue); // Ajusta a largura mantendo a proporção

                        // Ajustando a escala da logo para um tamanho específico
                        float fatorEscala = 0.2f;  // Reduzindo a logo para 30% do tamanho original
                        logo.ScalePercent(fatorEscala * 100); // Ajusta a escala para 30%

                        // Centralizando a logo
                        logo.Alignment = Element.ALIGN_CENTER;

                        // Adicionando a logo ao documento
                        doc.Add(logo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar logo: " + ex.Message);
                    }

                    // Adicionando o nome do paciente logo abaixo da logo sem negrito
                    iTextSharp.text.Font pacienteFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);  // Fonte normal (sem negrito)
                    Paragraph parPaciente = new Paragraph($"Paciente: {nomePaciente}", pacienteFont)
                    {
                        Alignment = Element.ALIGN_LEFT
                    };
                    doc.Add(new Paragraph(" "));

                    doc.Add(parPaciente);
                    doc.Add(new Paragraph(" ")); // Espaço entre o nome do paciente e a lista de exercícios
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph(" "));

                    // Adicionando o título da lista de exercícios
                    iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    tituloFont.SetStyle(iTextSharp.text.Font.UNDERLINE); // Adiciona o sublinhado

                    Paragraph titulo = new Paragraph("Lista de Exercícios", tituloFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };

                    doc.Add(titulo);
                    doc.Add(new Paragraph(" ")); // Espaço em branco
                    doc.Add(new Paragraph(" "));

                    // Adicionando os exercícios no PDF, com parte em negrito e justificado
                    foreach (string exercicio in listaExercicios)
                    {
                        // Separando a parte antes dos dois pontos
                        string[] partes = exercicio.Split(new char[] { ':' }, 2);

                        // Criando o parágrafo com a parte inicial em negrito
                        Paragraph parExercicio = new Paragraph
                        {
                            Alignment = Element.ALIGN_JUSTIFIED // Alinhamento justificado
                        };

                        if (partes.Length > 1)
                        {
                            // Adiciona a parte em negrito (antes dos dois pontos)
                            Chunk textoNegrito = new Chunk(partes[0] + ":", FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                            parExercicio.Add(textoNegrito);

                            // Adiciona a parte restante normalmente, com espaço após os dois pontos
                            parExercicio.Add(" " + partes[1].Trim());
                        }
                        else
                        {
                            // Se não houver dois pontos, adiciona o exercício normal
                            parExercicio.Add(exercicio);
                        }

                        // Adiciona o exercício no PDF
                        doc.Add(parExercicio);

                        // Adiciona um parágrafo em branco após o exercício
                        doc.Add(new Paragraph(" "));
                    }

                }
                    doc.Add(new Paragraph(" "));

                    doc.Close();
                    MessageBox.Show("PDF gerado com sucesso!");
                
            }
        }
        private void AdicionarLayoutPersonalizadoCD(Document doc, string nomePaciente)
        {
            string protocoloSelecionado = comboBox1.SelectedItem.ToString();

 
            // Adicionando a logo no cabeçalho
            try
            {
                // Caminho da logo
                string caminhoLogo = @"C:\Dev\cSharp\ProjetoOriginal\logos\logo.png"; // Caminho completo da logo

                // Carregando a imagem da logo
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);

                // Definindo alinhamento e escala
                float larguraPagina = doc.PageSize.Width - 80f; // Largura total disponível após as margens (40 unidades de cada lado)
                logo.ScaleToFit(larguraPagina, float.MaxValue); // Ajusta a largura mantendo a proporção

                // Ajustando a escala da logo para um tamanho específico
                float fatorEscala = 0.2f;  // Reduzindo a logo para 30% do tamanho original
                logo.ScalePercent(fatorEscala * 100); // Ajusta a escala para 30%

                // Centralizando a logo
                logo.Alignment = Element.ALIGN_CENTER;

                // Adicionando a logo ao documento
                doc.Add(logo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar logo: " + ex.Message);
            }
            
            doc.Add(new Paragraph(" "));

           

            // Espaçamento após a imagem adicional
            doc.Add(new Paragraph(" "));

            // Adicionando o título da lista de exercícios
            iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            tituloFont.SetStyle(iTextSharp.text.Font.UNDERLINE); // Adiciona o sublinhado
      

            // Layout específico para protocolos C e D
            Paragraph titulo = new Paragraph("Protocolo de Exercícios", tituloFont)
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(titulo);
            doc.Add(new Paragraph(" "));

            iTextSharp.text.Font pacienteFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
            Paragraph parPaciente = new Paragraph($"Paciente: {nomePaciente}", pacienteFont)
            {
                Alignment = Element.ALIGN_LEFT
            };
            doc.Add(parPaciente);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            
            //ADD a imagem antes dos exercicios, confore o protocolo selecionado.
            if (protocoloSelecionado == "Treinamento Domiciliar 01")
            {
                // Layout personalizado para treinamento domiciliar01

                try
                {

                    // Caminho da imagem
                    string caminhoImagem = @"C:\Dev\cSharp\ProjetoOriginal\Imagens\imagem01.png"; // Caminho completo da logo

                    // Carregando a imagem 
                    iTextSharp.text.Image imagem = iTextSharp.text.Image.GetInstance(caminhoImagem);

                    // Definindo alinhamento e escala
                    float larguraPagina = doc.PageSize.Width - 80f; // Largura total disponível após as margens (40 unidades de cada lado)
                    imagem.ScaleToFit(larguraPagina, float.MaxValue); // Ajusta a largura mantendo a proporção

                    // Ajustando a escala da logo para um tamanho específico
                    float fatorEscala = 0.4f;  // Reduzindo a logo para 40% do tamanho original
                    imagem.ScalePercent(fatorEscala * 100); // Ajusta a escala para 40%

                    // Centralizando a logo
                    imagem.Alignment = Element.ALIGN_CENTER;

                    // Adicionando a logo ao documento
                    doc.Add(imagem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar imagem adicional: " + ex.Message);
                }

            } else if (protocoloSelecionado == "Treinamento Domiciliar 02")

                {

                // Caminho da imagem
                string caminhoImagem = @"C:\Dev\cSharp\ProjetoOriginal\Imagens\imagem02.png"; // Caminho completo da imagem

                // Carregando a imagem 
                iTextSharp.text.Image imagem = iTextSharp.text.Image.GetInstance(caminhoImagem);

                // Definindo alinhamento e escala
                float larguraPagina = doc.PageSize.Width - 80f; // Largura total disponível após as margens (40 unidades de cada lado)
                imagem.ScaleToFit(larguraPagina, float.MaxValue); // Ajusta a largura mantendo a proporção

                // Ajustando a escala da logo para um tamanho específico
                float fatorEscala = 0.8f;  // Reduzindo a logo para 80% do tamanho original
                imagem.ScalePercent(fatorEscala * 100); // Ajusta a escala para 80%

                // Centralizando a logo
                imagem.Alignment = Element.ALIGN_CENTER;

                // Adicionando a logo ao documento
                doc.Add(imagem);

            }
            else if (protocoloSelecionado == "Treinamento Domiciliar 03")

            {

                // Caminho da imagem
                string caminhoImagem = @"C:\Dev\cSharp\ProjetoOriginal\Imagens\imagem03.png"; // Caminho completo da imagem

                // Carregando a imagem 
                iTextSharp.text.Image imagem = iTextSharp.text.Image.GetInstance(caminhoImagem);

                // Definindo alinhamento e escala
                float larguraPagina = doc.PageSize.Width - 80f; // Largura total disponível após as margens (40 unidades de cada lado)
                imagem.ScaleToFit(larguraPagina, float.MaxValue); // Ajusta a largura mantendo a proporção

                // Ajustando a escala da logo para um tamanho específico
                float fatorEscala = 0.3f;  // Reduzindo a logo para 80% do tamanho original
                imagem.ScalePercent(fatorEscala * 100); // Ajusta a escala para 80%

                // Centralizando a logo
                imagem.Alignment = Element.ALIGN_CENTER;

                // Adicionando a logo ao documento
                doc.Add(imagem);

            }


            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            foreach (string exercicio in listaExercicios)
            {
                // Separando a parte antes dos dois pontos
                string[] partes = exercicio.Split(new char[] { ':' }, 2);

                // Criando o parágrafo com a parte inicial em negrito
                Paragraph parExercicio = new Paragraph
                {
                    Alignment = Element.ALIGN_JUSTIFIED // Alinhamento justificado
                };

                if (partes.Length > 1)
                {
                    // Adiciona a parte em negrito (antes dos dois pontos)
                    Chunk textoNegrito = new Chunk(partes[0] + ":", FontFactory.GetFont(FontFactory.HELVETICA_BOLD));
                    parExercicio.Add(textoNegrito);

                    // Adiciona a parte restante normalmente, com espaço após os dois pontos
                    parExercicio.Add(" " + partes[1].Trim());
                }
                else
                {
                    // Se não houver dois pontos, adiciona o exercício normal
                    parExercicio.Add(exercicio);
                }

                // Adiciona o exercício no PDF
                doc.Add(parExercicio);

                // Adiciona um parágrafo em branco após o exercício
                doc.Add(new Paragraph(" "));
            }
        }
    }

    // Classe para adicionar rodapé ao PDF
    public class RodapePdf : PdfPageEventHelper
    {
        private string nomePaciente;
        private string nomeFisioterapeuta;
        private string crefitoFisioterapeuta;

        public RodapePdf(string paciente, string fisioterapeuta, string crefito)
        {
            nomePaciente = paciente;
            nomeFisioterapeuta = fisioterapeuta;
            crefitoFisioterapeuta = crefito;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            // Configurando a fonte para o rodapé
            iTextSharp.text.Font rodapeFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Adicionando o nome da fisioterapeuta no final (direita).
            Phrase nomeFisioterapeutaRodape = new Phrase($"Fisioterapeuta: {nomeFisioterapeuta} - {crefitoFisioterapeuta}", rodapeFont);
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_RIGHT, nomeFisioterapeutaRodape, document.PageSize.Width - 40, 40, 0);
        }
    }
}
