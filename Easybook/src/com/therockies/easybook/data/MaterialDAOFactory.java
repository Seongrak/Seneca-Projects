package com.therockies.easybook.data;

import ca.senecacollege.prg556.limara.dao.MaterialDAO;
import ca.dmay.easybook.data.DataSourceFactory;

//Seongrak Choi

public class MaterialDAOFactory {

	public static MaterialDAO getMaterialDAO()
	{
		return new MaterialData(DataSourceFactory.getDataSource());
	}
}
