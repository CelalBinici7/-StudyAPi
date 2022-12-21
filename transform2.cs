using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform2 : MonoBehaviour
{

    /* public Transform hedef;
     public Transform hedef2;*/
    // Start is called before the first frame update

    public Transform hedef;
    
    void Start()
    {
        //yazmış olunann esnada objeninn rotation u sıfırlar sıfırlar
        transform.rotation = Quaternion.identity;

       /* Vector3 bizimpozisyon = new Vector3(140, 70, 90);

        Quaternion yenipozisyon = Quaternion.Euler(bizimpozisyon);
        transform.rotation = yenipozisyon;*/
        /// Ona verilen kordinatlara göre hang eksen verilirse o eksene göre sırayla döndürürd euler komutu
       // transform.rotation = Quaternion.Euler(90, 0, 0);//sadece1 kere uygular update de tanımlansa bile
        //Aynı objenin kendi ekseni etrafında dönüşünü istiyorsak kullanılabilir
       // transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
        // transform.rotation = Quaternion.Euler(90, 0, 0);
        /* Vector3 fark = hedef.position - transform.position;

         transform.rotation = Quaternion.LookRotation(fark, Vector3.up);

         float angle = Quaternion.Angle(transform.rotation, hedef.rotation);
         print(angle);

         transform.rotation = Quaternion.Inverse(hedef.rotation);//hedef objenin pozisyonun tam tersini bizim objemize uygular ayna gibi
    */
    }
}
