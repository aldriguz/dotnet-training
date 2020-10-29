using System;

namespace Creational.FactoryMethod 
{
    //Products of FactoryMethod
    public interface IButton {
        string render();
        string onClick();
    }

    public class WindowButton : IButton {
        public string render() => "Window button has been rendered";
        public string onClick() => "Window button click performed";
    }

    public class HtmlButton : IButton {
        public string render() => "HTML button has been rendered";
        public string onClick() => "HTML button click performed";
    }


    //Creator class from factoryMethod
    public abstract class Dialog {
        public abstract IButton createButton();//FactoryMethod
        public string render(){
            IButton messageButton = createButton();
            messageButton.onClick();
            return messageButton.render();
        }

    }

    public class WindowDialog : Dialog {
        public override IButton createButton()
        {
            return new WindowButton();
        }

    }

    public class WebDialog : Dialog {
        public override IButton createButton()
        {
            return new HtmlButton();
        }
    }

    // Client code
    public class Application {
        private Dialog dialog;
        private string platformType;

        private void initialize(){
            if(this.platformType.Equals("Desktop")){
                this.dialog = new WindowDialog(); 
            }
            else if(this.platformType.Equals("Web")){
                this.dialog = new WebDialog();
            }
            else{
                throw new Exception("Platform is not supported!!");
            }
        }

        public void Main(string platformType){
            this.platformType = platformType;
            this.initialize();
            Console.WriteLine(this.dialog.render());
        }

    }

}