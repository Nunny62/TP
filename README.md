Предметная облсть: Интернет магазин цифровой и бытовой техники.

**Введение**

Электронная торговля в виртуальном магазине основывается на той же структуре, что и традиционная торговля. Преимущества виртуального магазина перед реальным очевидны. Уменьшается численность персонала за счет сокращения объема взаимодействия с клиентами, аренда оборудования или услуг виртуального-хостинга у хостинг провайдеров и размещение списка продаваемых товаров в виде каталога на сайте дешевле и проще аренды торговых помещений и размещения товаров на полках, нет нужды в кассовом обслуживании и так далее. Оплата товаров и услуг по доставке в виртуальных магазинах осуществляется с помощью различных платежных систем работающих в сети интернет.

Цель данной работы – проектирование информационной системы интернет- магазина.

Для достижения поставленной цели нужно выполнить ряд задач:
 
1.провести детальный анализ предметной области;

2.Построить диаграмму процесса покупки товара в интернет – магазине;

3.Построить диагрмму базы данных интернет магазина.

<font size="5"> **1.1  Описание предметной области** </font>

Предприятие для осуществления торговли через интернет не требует аренды торговых площадей для размещения товаров, поэтому рабочие места сотрудников будут базироваться в двух местах: арендуемый офис (также возможна удаленная работа на дому) и складские помещения. В арендуемом офисе могут работать сотрудники таких отделов, как: отдел продаж, отдел маркетинга, отдел информационных технологий, отдел закупок и бухгалтерский отдел. На складе, где хранятся закупленные для продажи товары, могут работать сотрудники почтового отдела, занимающиеся приемом, сортировкой, учетом и отправкой товаров.

Сотрудник каждого отдела должен иметь свое автоматизированное рабочее место, состоящее из ЭВМ с определенным набором программ. Так как интернет-магазин будет доступен по средствам веб- браузера, не требуется закупать мощные рабочие станции, для комфортной работы сотрудникам будет достаточно иметь бюджетные модели ПК.

Оплата заказов клиентами осуществляется наличными при получение или при помощи платежных систем, поддерживающих привязку к банковской карте. Все вырученные средства поступают на счет компании и затем обрабатываются сотрудниками бухгалтерского отдела. Данные обо всех финансовых операциях будут экспортироваться в корпоративную информационную систему 1С: Предприятие или другую систему, выбранную для эксплуатации. 

Почтовые отправления осуществляются с помощью различных компаний по отправке почты, таких как EMS, DHL, “Почта России” и других на выбор клиента. Клиент должен оплатить стоимость доставки самостоятельно, если ее стоимость не включена в стоимость товара. Выбор способа доставки осуществляется клиентом во время оформления заказа на веб-сайте. После отправки товара клиенту выдается номер почтового отправления (почтовый идентификатор), по которому можно отслеживать текущий статус и местоположение посылки. Денежные средства за оплаченный товар резервируются до тех пор, пока системой отслеживания почтовых отправлений не будут получены данные о том, что клиент получил свою посылку.

На предприятии, осуществляющем торговлю через интернет, обычно присутствуют следующие отделы:

* отдел продаж

* отдел маркетинга

* отдел закупок

* бухгалтерский отдел

* отдел информационных технологий

* отдел доствки

В основные функции отдела продаж входят: осуществление онлайн консультаций с клиентами, разрешение различных ситуаций возникших при оформлении заказа. Менеджеры имеют возможность вносить товары в каталог, редактировать описание и характеристики товаров, создавать новые разделы каталога, проверять отзывы клиентов оставленные о товаре.

Отдел маркетинга отвечает за анализ текущего положения на рынке, продвижение бренда магазина с помощью рекламы, анализ спроса и формирование списка товаров необходимых для закупки и его передача в отдел закупок.

Сотрудники отдела закупок отвечают за закупку различных товаров у поставщиков для осуществления их продажи в виртуальном магазине, в их обязанности также входит поиск поставщиков и связь с ними.

Бухгалтерский отдел осуществляет начисление заработной платы сотрудникам, распределение прибыли на другие нужды связанные с работой магазина и другие финансовые обязанности.

В отделе информационных технологий должны быть такие сотрудники как программист и системный администратор. В обязанности программиста входит поддержание программного комплекса виртуального магазина, внесение правок в код в связи с найденными ошибками, а также, по требованию, улучшение системы. Системный администратор должен следить за состоянием технического парка компьютеров предприятия, осуществлять администрирование веб-сервера магазина, администрировать базу данных, настраивать права доступа для различных групп пользователей через интерфейс администрирования сайта и другие действия по поддержанию нормального функционирования аппаратно-программной части предприятия.

В обязанности сотрудников отдела доствки входит получение товаров на складе и отправка заказанного товара покупателю. После подтверждения заказа в отдел доствки автоматически отправляется письмо о том, что был сделан заказ. Письмо содержит все данные для отправки товара. После упаковки и отправки товара сотрудник почтового отдела вводит на сайте магазина номер отслеживания почтового отравления для сделанного заказа. Сортирует и получает товар кладовщик, он же передает данные о полученном товаре менеджерам, которые вводят данные о товаре на сайте.

**1.2  Проблематика**

Для нормальной работы интернет-магазина необходима информационная система. 
* Для любого пользователя интернет-магазина одним из главных преимуществ являются скорость загрузки и простота навигации. К сожалению, иногда бывает сложно разобраться в запутанной иерархии сайта и найти нужную вещь. Ещё одним неприятным явлением иногда бывает плохой дизайн - слишком мелкий текст или яркие цвета от которых устают глаза. Поэтому главной задачей является создание интернет-магазина, в котором покупатель мог бы с легкостью ориентироваться, быстро находить нужный товар и покупать его. Большое внимание следует уделить и дизайну. Проанализировав несколько средств разработки выбрать оптимальное.
* Планируется создать базу данных в которой будет хранится информмация о клиентах, заказах, товарах, сотрудниках, тестах товаров и доставке. С помощью неё сотрудники  смогут вести учёт товаров, брать информацию о заказах, чтобы собирать и осуществлять доставку заказов. Также база данных будет соединена с сайтом чтобы клиет мог видеть наличие товара, информацию о его тестах и знать статус заказа.  

<font size="5"> **2.1  BPMN диаграмма процесса покупки товара в интернет – магазине** </font>

![BPMN 1](https://user-images.githubusercontent.com/105675947/193114932-5215895e-54e6-4372-8c98-d37f5c64d138.png)

<font size="5"> **2.2  Диаграмма базы данных интернет магазина** </font>

![Пустой документ - Страница 1 (2)](https://user-images.githubusercontent.com/105675947/198406426-3533aa01-af1e-40f2-be73-4ca780eaec91.png)


