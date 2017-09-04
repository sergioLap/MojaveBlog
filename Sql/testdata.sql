


-- Выполнение запроса:
INSERT INTO author(
            name, description, urlslug)
    VALUES ( 'Sergey Lpain', 'admin', 'sergey_lapin');



-- Выполнение запроса:
INSERT INTO category(
             name, description, urlslug)
    VALUES ('тест', 'тестовая категория', 'test');


INSERT INTO post(
             title, shortdescription, description, meta, urlslug, 
            published, datepost, datemodified, categoryid)
    VALUES ( 'первый', 'это первый пост лалалалалала', 'краткое описание', 'meta', 'fist_post', 
            true, '2017-09-01', null, 1);

			INSERT INTO tag(
             name, description, urlslug)
    VALUES ( 'тесттэг', 'тестирование', 'test_teg');

INSERT INTO post_author(
            post_id, author_id)
    VALUES (1, 1);

	
INSERT INTO post_tag(
            post_id, tag_id)
    VALUES (1, 1);
