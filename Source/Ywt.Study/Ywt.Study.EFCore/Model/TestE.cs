using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ywt.Study.EFCore
{
    /// <summary>
    /// 测试 索引器属性
    /// </summary>
    public class TestE
    {
        public int Id { get; set; }
        public string Field { get; set; }

        private readonly Dictionary<string, object> _data = new Dictionary<string, object>();
        public object this[string key]
        {
            get => _data[key];
            set => _data[key] = value;
        }
    }
}
