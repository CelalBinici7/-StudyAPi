metin = """Bu projenin amacı github kullanmayı öğretmek,sırası ile:
 githuba bağlanma,
 githuba commit etme vs.""" 





aranan_harf = input("Lütfen aradığınız harfi giriniz:\t")

adet =0

for karakter in metin:
	if karakter == aranan_harf:
		adet+=1

print(adet)
