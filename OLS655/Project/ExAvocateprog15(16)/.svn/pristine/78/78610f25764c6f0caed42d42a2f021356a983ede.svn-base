DROP SEQUENCE exav_id_sequence;

DROP TABLE apply;
DROP TABLE exav;
DROP TABLE applicant;

CREATE TABLE applicant
(
	username VARCHAR2(30)
		CONSTRAINT applicant_username_nn NOT NULL
		CONSTRAINT applicant_pk PRIMARY KEY,
	first_name VARCHAR2(40)
		CONSTRAINT applicant_first_name_nn NOT NULL,
	last_name VARCHAR2(40)
		CONSTRAINT applicant_last_name_nn NOT NULL
);

CREATE TABLE exav
(
	id NUMBER(2)
		CONSTRAINT exav_id_nn NOT NULL
		CONSTRAINT exav_id_ck CHECK(id > 0)
		CONSTRAINT exav_pk PRIMARY KEY,
	description VARCHAR2(80)
		CONSTRAINT exav_description_nn NOT NULL,
	max_applicants NUMBER(2)
		CONSTRAINT exav_max_applicants_nn NOT NULL
		CONSTRAINT exav_max_applicants_ck CHECK (max_applicants > 0)
);

CREATE TABLE apply
(
	applicant_username VARCHAR2(30)
		CONSTRAINT apply_applicant_username_nn NOT NULL
		CONSTRAINT apply_applicant_username_fk REFERENCES applicant(username),
	exav_id NUMBER(4)
		CONSTRAINT apply_exav_id_nn NOT NULL
		CONSTRAINT apply_exav_id_fk REFERENCES exav(id),
	month NUMBER(2)
		CONSTRAINT apply_month_nn NOT NULL
		CONSTRAINT apply_month_ck CHECK(month BETWEEN 1 AND 12),
	CONSTRAINT apply_pk PRIMARY KEY(applicant_username, exav_id)
);

CREATE SEQUENCE exav_id_sequence
INCREMENT BY 1;

INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Volcano bungee jumping', 1);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Wingsuit BASE jumping', 8);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Shark Riding', 10);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Hot Coal Walking', 12);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Freebasing', 2);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Extreme Highlining', 4);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Alligator Wrestling', 12);
INSERT INTO exav (id, description, max_applicants) VALUES (exav_id_sequence.NEXTVAL, 'Bear Wrestling', 6);
COMMIT;

INSERT INTO applicant (username, first_name, last_name) VALUES ('ols655_202a59', 'Seongrak', 'Choi');
INSERT INTO applicant (username, first_name, last_name) VALUES ('ols655_202a26', 'Oluwaseun', 'Kelani');
INSERT INTO applicant (username, first_name, last_name) VALUES ('ols655_202a41', 'Albright', 'Nsubuga');

-- Add additional lines for your partners when presenting
COMMIT;

CREATE OR REPLACE FUNCTION IS_EXAV_AVAILABLE
(
  pexav_id NUMBER
)
RETURN NUMBER
IS
  total NUMBER;
  user_name apply.applicant_username%TYPE;
BEGIN
  SELECT USER INTO user_name FROM dual;
  SELECT COUNT(*) INTO total FROM apply WHERE exav_id = pexav_id AND applicant_username = LOWER(user_name);
  IF total > 0 THEN
  	RETURN 1;
  ELSE
  	RETURN 0;
  END IF;
END;
/
COMMIT;