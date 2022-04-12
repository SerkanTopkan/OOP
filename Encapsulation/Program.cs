namespace Parent
{
    public class A
    {
        public A()
        {
            //B erişim yok
            C c = new C();//Erişim var
        }

        protected void T()
        {

        }

    }

    public class E : A
    {
        public E()
        {
            T();//protected imzalı methoda kalıtım alındığı için erişim var
        }
    }

    private class B
    {
        public B()
        {
            A a = new A();//Erişim var
            //A.T Erişim Yok
            C c = new C();//Erişim var     
        }
    }

    internal class C
    {
        //B Erişim yok
        public C()
        {
            A a = new A();//Erişim var
            //a.T Erişim yok


        }
    }
}

namespace Child
{
    using Parent;
    public class D
    {
        public D()
        {
            A a = new A();//Erişim var
                          //B Erişim yok
            C c = new C();//Erişim var
            //a.T Erişim yok
        }

    }
}