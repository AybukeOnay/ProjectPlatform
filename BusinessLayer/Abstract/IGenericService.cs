using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        List<T> TListeleBL();
        void TEkleBL(T cls_t);
        T TIDIleGetirBL(int vrb_id);
        void TSilBL(T cls_t);
        void TGuncelleBL(T cls_t);
        T TFiltrelemeyeGoreGetirBL(Expression<Func<T, bool>> filter = null);
        
    }
}
