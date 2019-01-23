
using Jieba.Net.Core.Properties;
using System;
using System.Diagnostics;
using System.IO;

namespace JiebaNet.Segmenter
{
    public class ConfigManager
    {
        public static string ConfigFileBaseDir
        {
            get
            {
                return "JiebaResources";
            }
        }

        public static string MainDictFile
        {
            get
            {
                string file = Path.Combine(ConfigFileBaseDir, "dict.txt");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.dict);
                }
                return file;
            }
        }

        public static string ProbTransFile
        {
            get
            {
                string file = Path.Combine(ConfigFileBaseDir, "prob_trans.json");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.prob_trans);
                }
                return file;
            }
        }

        public static string ProbEmitFile
        {
            get
            {
                string file = Path.Combine(ConfigFileBaseDir, "prob_emit.json");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.prob_emit);
                }
                return file;
            }
        }

        public static string PosProbStartFile
        {
            get
            {
                {
                    string file = Path.Combine(ConfigFileBaseDir, "pos_prob_start.json");
                    if (!File.Exists(file))
                    {
                        string folder = Path.Combine(ConfigFileBaseDir);
                        if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                        File.WriteAllText(file, Resources.pos_prob_start);
                    }
                    return file;
                }
            }
        }

        public static string PosProbTransFile
        {
            get
            {

                string file = Path.Combine(ConfigFileBaseDir, "pos_prob_trans.json");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.pos_prob_trans);
                }
                return file;
            }
        }

        public static string PosProbEmitFile
        {
            get
            {
                string file = Path.Combine(ConfigFileBaseDir, "pos_prob_trans.json");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.pos_prob_trans);
                }
                return file;
            }
        }

        public static string CharStateTabFile
        {
            get
            {
                string file = Path.Combine(ConfigFileBaseDir, "char_state_tab.json");
                if (!File.Exists(file))
                {
                    string folder = Path.Combine(ConfigFileBaseDir);
                    if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                    File.WriteAllText(file, Resources.char_state_tab);
                }
                return file;
            }
        }
    }
}