


-- Table: author

-- DROP TABLE author;

CREATE TABLE author
(
  authorid integer NOT NULL ,
  name character varying(50) NOT NULL,
  urlslug character varying(200) NOT NULL,
  description text,
  CONSTRAINT author_pkey PRIMARY KEY (authorid)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE author
  OWNER TO postgres;

  
  
-- Table: category

-- DROP TABLE category;

CREATE TABLE category
(
  categoryid integer NOT NULL ,
  name character varying(50) NOT NULL,
  urlslug character varying(50) NOT NULL,
  description character varying(200),
  CONSTRAINT category_pkey PRIMARY KEY (categoryid)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE category
  OWNER TO postgres;

  
  
  -- Table: tag

-- DROP TABLE tag;

CREATE TABLE tag
(
  tagid integer NOT NULL,
  name character varying(50) NOT NULL,
  urlslug character varying(50) NOT NULL,
  description character varying(200),
  CONSTRAINT tag_pkey PRIMARY KEY (tagid)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE tag
  OWNER TO postgres;
  
  
  
-- Table: post

-- DROP TABLE post;

CREATE TABLE post
(
  postid integer NOT NULL,
  title character varying(500) NOT NULL,
  shortdescription text NOT NULL,
  description text NOT NULL,
  meta character varying(1000) NOT NULL,
  urlslug character varying(200) NOT NULL,
  published boolean NOT NULL,
  datepost timestamp without time zone NOT NULL,
  datemodified timestamp without time zone,
  categoryid integer NOT NULL,
  category integer,
  CONSTRAINT post_pkey PRIMARY KEY (postid),
  CONSTRAINT post_postid_category_categoryid FOREIGN KEY (categoryid)
      REFERENCES category (categoryid) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE post
  OWNER TO postgres;
  
  
  -- Table: post_author

-- DROP TABLE post_author;

CREATE TABLE post_author
(
  author_id integer NOT NULL,
  post_id integer NOT NULL,
  CONSTRAINT author_id_author_authorid FOREIGN KEY (author_id)
      REFERENCES author (authorid) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT post_id_post_postid FOREIGN KEY (post_id)
      REFERENCES post (postid) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE post_author
  OWNER TO postgres;
  
  
  -- Table: post_tag

-- DROP TABLE post_tag;

CREATE TABLE post_tag
(
  post_id integer NOT NULL,
  tag_id integer NOT NULL,
  CONSTRAINT post_id_post_postid FOREIGN KEY (post_id)
      REFERENCES post (postid) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT tag_id_tag_tagid FOREIGN KEY (tag_id)
      REFERENCES tag (tagid) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
  CONSTRAINT post_tag_uniq UNIQUE (post_id, tag_id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE post_tag
  OWNER TO postgres;

  
  CREATE SEQUENCE auto_id_author;
ALTER TABLE author ALTER COLUMN authorid SET DEFAULT nextval('auto_id_author'::regclass);
ALTER SEQUENCE auto_id_author OWNED BY author.authorid;

CREATE SEQUENCE auto_id_category;
ALTER TABLE category  ALTER COLUMN categoryid SET DEFAULT nextval('auto_id_category'::regclass);
ALTER SEQUENCE auto_id_category OWNED BY category.categoryid;

CREATE SEQUENCE auto_id_post;
ALTER TABLE post  ALTER COLUMN postid SET DEFAULT nextval('auto_id_post'::regclass);
ALTER SEQUENCE auto_id_post OWNED BY post.postid;

CREATE SEQUENCE auto_id_tag;
ALTER TABLE tag  ALTER COLUMN tagid SET DEFAULT nextval('auto_id_tag'::regclass);
ALTER SEQUENCE auto_id_tag OWNED BY tag.tagid;

