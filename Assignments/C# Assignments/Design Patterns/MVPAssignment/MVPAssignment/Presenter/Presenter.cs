using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVPAssignment
{
    public class Presenter
    {
        IView _pView;
        IModel _pModel;
        public Presenter(IView PView, IModel PModel)
        {
            _pView = PView;
            _pModel = PModel;
        }
        public void BindModalView()
        {
            List<String> ls = _pModel.setInfo();
            _pView.Label = ls[0];
            _pView.TextBox = ls[1];
        }
    }
}