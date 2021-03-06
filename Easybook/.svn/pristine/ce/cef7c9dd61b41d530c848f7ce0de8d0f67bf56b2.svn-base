package com.therockies.easybook.data;

//Seongrak Choi
import java.sql.SQLException;

import javax.sql.DataSource;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import ca.senecacollege.prg556.limara.bean.AccountOwner;
import ca.senecacollege.prg556.limara.dao.AccountOwnerDAO;

class AccountOwnerData implements AccountOwnerDAO {

	private DataSource ds;

	AccountOwnerData(DataSource ds)
	{
		setDs(ds);
	}

	@Override
	public AccountOwner getAccountOwner(int id) throws SQLException {
		// TODO Auto-generated method stub
		
		try (Connection conn = getDs().getConnection())
		{
			try (PreparedStatement pstmt = conn.prepareStatement("SELECT id, first_name, last_name FROM accountowner WHERE id = ?"))
			{
				pstmt.setInt(1, id);
				try (ResultSet rslt = pstmt.executeQuery())
				{
					if(rslt.next())
						return new AccountOwner(rslt.getInt("id"),rslt.getString("first_name"),rslt.getString("last_name"));
					else
						return null;
				}
			}
		}	
	}

	@Override
	public AccountOwner validateAccountOwner(String username, String password)
			throws SQLException {
		// TODO Auto-generated method stub
		
		try (Connection conn = getDs().getConnection())
		{
			try (PreparedStatement pstmt = conn.prepareStatement("SELECT id FROM accountowner WHERE username = ? AND password = ?"))
			{
				pstmt.setString(1, username);
				pstmt.setString(2, password);
				try (ResultSet rslt = pstmt.executeQuery())
				{
					if (rslt.next())
						return getAccountOwner(rslt.getInt("id"));
					else
						return null;
				}
			}
		}
	}
	
	private DataSource getDs()
	{
		return ds;
	}

	private void setDs(DataSource ds)
	{
		this.ds = ds;
	}

}
