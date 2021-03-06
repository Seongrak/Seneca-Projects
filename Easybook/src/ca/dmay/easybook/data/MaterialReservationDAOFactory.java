package ca.dmay.easybook.data;

import com.therockies.easybook.data.*;

import ca.senecacollege.prg556.limara.dao.MaterialReservationDAO;

// Darien May

public class MaterialReservationDAOFactory {

	/*
	public MaterialReservationDAOFactory() {
		// TODO Auto-generated constructor stub
	}
	
	*/
	
	public static MaterialReservationDAO getMaterialReservationDAO() {
		// return new MaterialData(DataSourceFactory.getDataSource());
		return new MaterialReservationData(DataSourceFactory.getDataSource());
	}

}
