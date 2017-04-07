using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GovDocSearch.cc.topware.form.comp
{
    class ConfigInfo
    {
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public static string loadConfig(string keyName)
        {
            string value = "";
            //http://192.168.15.224:8080
            //http://115.29.2.86:5901
            //http://192.168.15.156:8080
            Dictionary<string, string> configDictionary = new Dictionary<string, string>();
            configDictionary.Add("mainPage", "http://192.168.15.224:8080/topware-govdocsearch/");
            configDictionary.Add("remote", "http://192.168.15.224:8080/topware-govdocsearch/");
            configDictionary.Add("upload", "http://192.168.15.224:8080/topware-govdocsearch/web/dw/doc/upload.do?");

            if (configDictionary.ContainsKey(keyName))
            {
                value = configDictionary[keyName];
            }
            //foreach (KeyValuePair<string, string> item in configDictionary)
            //{
            //    if (item.Key == keyName)
            //    {
            //        value = item.Value;
            //        break;
            //    } 

            //
            return value;
        }
     
    }
}
