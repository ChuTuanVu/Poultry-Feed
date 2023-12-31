USE [btl]
GO
/****** Object:  Table [dbo].[hoadon]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadon](
	[tennguoidung] [nvarchar](25) NOT NULL,
	[tensanpham] [nvarchar](100) NOT NULL,
	[soluong] [int] NOT NULL,
	[tongtien] [float] NOT NULL,
	[ngaytao] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoadonnhap]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadonnhap](
	[masanpham] [nvarchar](10) NOT NULL,
	[tensanpham] [nvarchar](100) NULL,
	[soluong] [int] NULL,
	[gia] [float] NULL,
	[thanhtien] [float] NULL,
	[nhacungcap] [nvarchar](100) NULL,
	[ngaynhap] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[manhacungcap] [nvarchar](10) NOT NULL,
	[tennhacungcap] [nvarchar](100) NULL,
	[diachi] [nvarchar](255) NULL,
	[sodienthoai] [nvarchar](10) NULL,
	[ngayky] [date] NULL,
	[ngayhethan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [nvarchar](50) NOT NULL,
	[hotennhanvien] [nvarchar](100) NULL,
	[sodienthoai] [nvarchar](10) NULL,
	[gioitinh] [nvarchar](3) NULL,
	[email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanpham](
	[masanpham] [nvarchar](10) NOT NULL,
	[tensanpham] [nvarchar](100) NULL,
	[soluong] [int] NULL,
	[gia] [nvarchar](max) NULL,
	[loai] [nvarchar](5) NULL,
	[mota] [nvarchar](max) NULL,
	[nhacungcap] [nvarchar](100) NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tennguoidung] [nvarchar](25) NOT NULL,
	[matkhau] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[sodienthoai] [nvarchar](10) NULL,
	[ngaysinh] [date] NULL,
	[ngaydangky] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[tennguoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai], [ngayky], [ngayhethan]) VALUES (N'01', N'Công ty CP chăn nuôi C.P. Việt Nam', N'TP. Biên Hòa, Tỉnh Đồng Nai', N'0213836251', CAST(N'2020-10-31' AS Date), CAST(N'2022-10-31' AS Date))
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai], [ngayky], [ngayhethan]) VALUES (N'02', N'Công ty TNHH Cargill Việt Nam', N'Q.7, TP Hồ Chí Minh', N'0254161515', CAST(N'2018-05-10' AS Date), CAST(N'2029-05-10' AS Date))
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai], [ngayky], [ngayhethan]) VALUES (N'03', N'De Heus Việt Nam', N'TP. Thủ Đức, TP. Hồ Chí Minh', N'0837402745', CAST(N'2011-10-12' AS Date), CAST(N'2021-10-12' AS Date))
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai], [ngayky], [ngayhethan]) VALUES (N'04', N'Công ty cổ phần Tập đoàn DABACO Việt Nam', N'TP. Bắc Ninh, Tỉnh Bắc Ninh', N'0313826077', CAST(N'2022-01-01' AS Date), CAST(N'2026-01-01' AS Date))
INSERT [dbo].[nhacungcap] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai], [ngayky], [ngayhethan]) VALUES (N'05', N'TT phân phối thuốc trang trại FARMVET', N'Huyện Kim Thành, Tỉnh Hải Dương', N'0977565565', CAST(N'2010-06-06' AS Date), CAST(N'2030-06-06' AS Date))
GO
INSERT [dbo].[nhanvien] ([manhanvien], [hotennhanvien], [sodienthoai], [gioitinh], [email]) VALUES (N'10122410', N'Chu Tuấn Vũ', N'0986404914', N'Nam', N'chutuanvu020604@gmail.com')
GO
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CG1', N'Thức ăn hỗn hợp cho gà thịt từ 1 đến 10 ngày tuổi', 100, N'90', N'Gà', N'Thành phần: Khô đậu tương, ngô, lúa mỳ, bột cá, bột thịt xương, gluten, cám gạo, dầu thực vật, enzym, các axit amin cần thiết, premix khoáng và vitamin. Hướng dẫn sử dụng:  Thức ăn hỗn hợp đã cân đối đầy đủ chất dinh dưỡng, không cần pha trộn thêm bất kỳ nguyên liệu gì khác. Đảm bảo cung cấp nước sạch cho gà. Bảo quản:  Màu sắc thay đổi không ảnh hưởng đến chất lượng sản phẩm. Bảo quản nơi khô ráo, thoáng mát và tránh ánh sáng trực tiếp. Hạn sử dụng: 60 ngày kể từ NSX', N'Công ty TNHH Cargill Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CG2', N'Thức ăn hỗn hợp cho gà thịt từ 11 đến 21 ngày tuổi', 100, N'120', N'Gà', N'Thành phần: Khô đậu tương, ngô, lúa mỳ, bột cá, bột thịt xương, gluten, cám gạo, dầu thực vật, enzym, các axit amin cần thiết, premix khoáng và vitamin. Hướng dẫn sử dụng:  Thức ăn hỗn hợp đã cân đối đầy đủ chất dinh dưỡng, không cần pha trộn thêm bất kỳ nguyên liệu gì khác. Đảm bảo cung cấp nước sạch cho gà. Bảo quản:  Màu sắc thay đổi không ảnh hưởng đến chất lượng sản phẩm. Bảo quản nơi khô ráo, thoáng mát và tránh ánh sáng trực tiếp. Hạn sử dụng: 60 ngày kể từ NSX.', N'Công ty TNHH Cargill Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CG3', N'Thức ăn hỗn hợp cho gà thịt từ 22 ngày đến trước khi xuất chuồng', 100, N'150', N'Gà', N'Thành phần: Khô đậu tương, ngô, lúa mỳ, bột cá, bột thịt xương, gluten, cám gạo, dầu thực vật, enzym, các axit amin cần thiết, premix khoáng và vitamin. Hướng dẫn sử dụng:  Thức ăn hỗn hợp đã cân đối đầy đủ chất dinh dưỡng, không cần pha trộn thêm bất kỳ nguyên liệu gì khác. Đảm bảo cung cấp nước sạch cho gà. Bảo quản:  Màu sắc thay đổi không ảnh hưởng đến chất lượng sản phẩm. Bảo quản nơi khô ráo, thoáng mát và tránh ánh sáng trực tiếp. Hạn sử dụng: 60 ngày kể từ NSX.', N'Công ty TNHH Cargill Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CGV1', N'Thức ăn hỗn hợp hoàn chỉnh cao cấp cho ngan và vịt con từ 1-21 ngày', 100, N'200', N'Vịt', N'Thành phần: Ngô, tấm, đạm động vật, đạm thực vật, đậu nành, cám gạo, cám mì, các acid amin, các chất bổ sung vitamin và khoáng... Hướng dẫn sử dụng: Thức ăn này cho vịt, ngan siêu thịt từ 1 ngày đến 21 ngày tuổi. Cho ăn nhiều lần trong ngày, không cần pha trộn với các loại nguyên liệu khác. Cung cấp đầy đủ nước uống sạch và mát cho vật nuôi. Màu sắc sản phẩm thay đổi không ảnh hưởng đến chất lượng sản phẩm.', N'Công ty TNHH Cargill Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CGV2', N'Thức ăn hỗn hợp hoàn chỉnh cho ngan và vịt thịt từ 22 ngày đến xuất chuồng', 100, N'220', N'Vịt', N'Thành phần: Ngô, tấm, đạm động vật, đạm thực vật, đậu nành, cám gạo, cám mì, các acid amin, các chất bổ sung vitamin và khoáng... Hướng dẫn sử dụng: Thức ăn này cho vịt, ngan siêu thịt từ 1 ngày đến 21 ngày tuổi. Cho ăn nhiều lần trong ngày, không cần pha trộn với các loại nguyên liệu khác. Cung cấp đầy đủ nước uống sạch và mát cho vật nuôi. Màu sắc sản phẩm thay đổi không ảnh hưởng đến chất lượng sản phẩm.', N'Công ty TNHH Cargill Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CPG1', N'Thức ăn hỗn hợp dạng mảnh. Gà con lông màu (1 ngày - 21 ngày tuổi)
', 100, N'230', N'Gà', N'Sử dụng nguyên liệu được tinh chọn với những tiêu chuẩn khắc khe về tính an toàn, hàm lượng dưỡng chất thiết yếu,...Đặc biệt sử dụng các loại axit hữu cơ, men tiêu hoá (probiotic, enzyme),...giúp tăng cường sức đề kháng đường ruột, tăng khả năng hấp thu dưỡng chất thức ăn.', N'Công ty CP chăn nuôi C.P. Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CPG2', N'Thức ăn hỗn hợp dạng mảnh. Gà con lông màu (22 ngày - 42 ngày tuổi)
', 100, N'500', N'Gà', N'Sử dụng nguyên liệu được tinh chọn với những tiêu chuẩn khắc khe về tính an toàn, hàm lượng dưỡng chất thiết yếu,...Đặc biệt sử dụng các loại axit hữu cơ, men tiêu hoá (probiotic, enzyme),...giúp tăng cường sức đề kháng đường ruột, tăng khả năng hấp thu dưỡng chất thức ăn.', N'Công ty CP chăn nuôi C.P. Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'CPG3', N'Thức ăn hỗn hợp dạng mảnh. Gà con lông màu (43 ngày - xuất chuồng)', 100, N'550', N'Gà', N'Sử dụng nguyên liệu được tinh chọn với những tiêu chuẩn khắc khe về tính an toàn, hàm lượng dưỡng chất thiết yếu,...Đặc biệt sử dụng các loại axit hữu cơ, men tiêu hoá (probiotic, enzyme),...giúp tăng cường sức đề kháng đường ruột, tăng khả năng hấp thu dưỡng chất thức ăn.', N'Công ty CP chăn nuôi C.P. Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCG1', N'Thức ăn hỗn hợp cho gà đẻ trứng từ 18 tuần tuổi đến kết thúc
', 100, N'600', N'Gà', N'Nguyên liệu chính: Bột, tấm, bột cá, đạm đậu nành, cám gạo, cám mì, các acid amin, các chất bổ sung vitamin và khoáng...(* Màu sắc sản phẩm đôi khi có thay đổi nhưng hoàn toàn không ảnh hưởng đến chất lượng). Cách dùng: Dùng cho gà đẻ giai đoạn 1: từ 18 - 50 tuần tuổi. Thức ăn hỗn hợp hoàn chỉnh, có đầy đủ chất dinh dưỡng, không cần pha trộn thêm với bất kì thức ăn nào khác ngoài nước uống. *Bảo quản nơi khô, mát, tránh ánh nắng mặt trời chiếu vào.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCG2', N'Thức ăn hỗn hợp cho gà vàng thả vườn từ 1 ngày tuổi đến xuất bán
', 100, N'150', N'Gà', N'Nguyên liệu chính: Ngô, tấm, đạm động vật, đạm thực vật, đậu nành, cám gạo, cám mì, các acid amin, các chất bổ sung vitamin và khoáng...Cách dùng: Thức ăn này cho gà thả vườn từ 1 ngày tuổi đến xuất chuồng. Cho ăn nhiều lần trong ngày, không cần pha trộn với các loại nguyên liệu khác. Cung cấp đầy đủ nước uống sạch và mát cho vật nuôi. Màu sắc sản phẩm thay đổi không ảnh hưởng đến chất lượng sản phẩm.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCG3', N'Thức ăn hỗn hợp cho gà vàng thả vườn từ 90 ngày tuổi đến xuất bán
', 100, N'300', N'Gà', N'Nguyên liệu chính: Ngô, tấm, đạm động vật, đạm thực vật, đậu nành, cám gạo, cám mì, các acid amin, các chất bổ sung vitamin và khoáng...Cách dùng: Thức ăn này cho gà thả vườn từ 1 ngày tuổi đến xuất chuồng. Cho ăn nhiều lần trong ngày, không cần pha trộn với các loại nguyên liệu khác. Cung cấp đầy đủ nước uống sạch và mát cho vật nuôi. Màu sắc sản phẩm thay đổi không ảnh hưởng đến chất lượng sản phẩm.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCV1', N'Thức ăn hỗn hợp cho ngan, vịt thịt từ 1 ngày tuổi - xuất bán
', 100, N'200', N'Vịt', N'Thành phần thức ăn: Ngô, bột cá, bột thịt, cám gạo, cám mì, khô đậu tương, các axit amin, các chất bổ sung khoáng và vitamine. Bảo quản nơi khô, mát, tránh ánh nắng trực tiếp, đậy kín miệng bao sau khi sử dụng. Hạn sử dụng: 60 ngày kể từ ngày sản xuất. Khối lượng tịnh: 25kg. Hướng dẫn sử dụng:  Dùng cho vịt, ngan thịt giai đoạn từ 01 ngày tuổi đến xuất bán. Cung cấp đầy đủ máng ăn, máng uống cho vịt, ngan. Nước uống cần luôn luôn sạch và mát. Thức ăn đã cân đối đầy đủ dinh dưỡng, không cần pha trộn với các thực liệu khác. Kí hiệu: Ngày sản xuất/số lô/KSHC: xem trên bao bì.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCV2', N'Thức ăn hỗn hợp cho ngan, vịt từ 28 ngày tuổi - xuất bán
', 100, N'245', N'Vịt', N'Thành phần thức ăn: Ngô, bột cá, bột thịt, cám gạo, cám mì, khô đậu tương, các axit amin, các chất bổ sung khoáng và vitamine. Bảo quản nơi khô, mát, tránh ánh nắng trực tiếp, đậy kín miệng bao sau khi sử dụng. Hạn sử dụng: 60 ngày kể từ ngày sản xuất. Khối lượng tịnh: 25kg. Hướng dẫn sử dụng:  Dùng cho vịt, ngan thịt giai đoạn từ 01 ngày tuổi đến xuất bán. Cung cấp đầy đủ máng ăn, máng uống cho vịt, ngan. Nước uống cần luôn luôn sạch và mát. Thức ăn đã cân đối đầy đủ dinh dưỡng, không cần pha trộn với các thực liệu khác. Kí hiệu: Ngày sản xuất/số lô/KSHC: xem trên bao bì.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DBCV3', N'Thức ăn hỗn hợp cho ngan, vịt từ 48 ngày tuổi - xuất bán
', 100, N'350', N'Vịt', N'Thành phần thức ăn: Ngô, bột cá, bột thịt, cám gạo, cám mì, khô đậu tương, các axit amin, các chất bổ sung khoáng và vitamine. Bảo quản nơi khô, mát, tránh ánh nắng trực tiếp, đậy kín miệng bao sau khi sử dụng. Hạn sử dụng: 60 ngày kể từ ngày sản xuất. Khối lượng tịnh: 25kg. Hướng dẫn sử dụng:  Dùng cho vịt, ngan thịt giai đoạn từ 01 ngày tuổi đến xuất bán. Cung cấp đầy đủ máng ăn, máng uống cho vịt, ngan. Nước uống cần luôn luôn sạch và mát. Thức ăn đã cân đối đầy đủ dinh dưỡng, không cần pha trộn với các thực liệu khác. Kí hiệu: Ngày sản xuất/số lô/KSHC: xem trên bao bì.', N'Công ty cổ phần Tập đoàn DABACO Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGCN1', N'Thức ăn hỗn hợp gà thịt công nghiệp từ 1 - 14 ngày tuổi
', 100, N'120', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…)', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGCN2', N'Thức ăn hỗn hợp gà thịt công nghiệp từ 15 - 28 ngày tuổi
', 100, N'300', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…)', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGCN3', N'Thức ăn hỗn hợp gà thịt công nghiệp từ 29 ngày - xuất chuồng', 100, N'500', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…)', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGV1', N'Thức ăn hỗn hợp gà thịt thả vườn từ 1 - 28 ngày tuổi', 100, N'340', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. Cân bằng Acid Amin cho thịt dai và ngon. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…). Cân bằng điện giải, hạn chế cắn mổ khi bị stress nhiệt.', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGV2', N'Thức ăn hỗn hợp gà thịt thả vườn từ 29 - 42 ngày tuổi
', 100, N'360', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. Cân bằng Acid Amin cho thịt dai và ngon. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…). Cân bằng điện giải, hạn chế cắn mổ khi bị stress nhiệt.', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHGV3', N'Thức ăn hỗn hợp gà thịt thả vườn từ 43 ngày tới xuất chuồng', 100, N'400', N'Gà', N'Cung cấp sắc tố tự nhiên cho màu da và chân đẹp. Cấu trúc thức ăn mảnh phù hợp, tăng tính thèm ăn và giảm hao hụt. Bổ sung nguồn khoáng hữu cơ, giúp cho chân khỏe chắc. Cân bằng Acid Amin cho thịt dai và ngon. FCR ( hệ số chuyển đổi thức ăn) thấp, giảm giá thành, tăng lợi nhuận. Giảm bài thải các chất gây ô nhiễm trong chuồng trại ( NH3, H2S,…). Cân bằng điện giải, hạn chế cắn mổ khi bị stress nhiệt.', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHV1', N'Thức ăn hỗn hợp vịt thịt từ 1 - 21 ngày tuổi', 100, N'700', N'Vịt', N'Hàm lượng dinh dưỡng cao, vịt tăng trưởng nhanh với FCR tối ưu. Hỗ trợ tiêu hóa tối đa, kích thích tính thèm ăn, tăng sức đề kháng, giảm chi phí chăn nuôi. Kỹ thuật ép viên tối ưu giúp giảm lượng hao hụt thức ăn. Áp dụng hệ thống quản lý chất lượng thức ăn an toàn: ISO 22000:2005 và GlobalG.A.P, đảm bảo nguồn thực phẩm sạch, truy xuất được nguồn gốc.', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'DHV2', N'Thức ăn hỗn hợp vịt thịt từ 22 ngày - xuất chuồng', 100, N'800', N'Vịt', N'Hàm lượng dinh dưỡng cao, vịt tăng trưởng nhanh với FCR thấp. Chất lượng cao, ổn định. Hỗ trợ tiêu hóa tối đa, tăng sức đề kháng, giảm chi phí thú y. Kích thích tính thèm ăn, không hao hụt nhờ kỹ thuật ép viên tối ưu, viên cứng chắc, không bể nát.', N'De Heus Việt Nam')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'VX1', N'Vắc xin cúm H5N1 re6 ( rtd ) 250ml ( 500 liều )', 100, N'220000', N'Thuốc', N'Thành phần: Virus cúm gia cầm subtype h5n1 chủng re6. Hiệu giá ha của dung dịch virus ≥ 8log2.
Dạng bào chế: Nhũ dầu màu trắng sữa.
Công dụng: Phòng bệnh cúm do virus gia cầm subtype h5n1 gây ra cho gà, vịt, ngan.
Liều dùng: Tiêm bắp lườn hoặc dưới da cổ. Gà từ 2-5 tuần tuổi: 0,3ml/con. Gà từ 5 tuần tuổi trở lên: 0,5ml/con. Vịt ngan từ 2-5 tuần tuổi: 0,3ml/con. Vịt ngan từ 5 tuần tuổi trở lên: 1ml/con.
Quy cách: đóng chai 250ml. Bảo quản: 2-80c.', N'TT phân phối thuốc trang trại FARMVET')
INSERT [dbo].[sanpham] ([masanpham], [tensanpham], [soluong], [gia], [loai], [mota], [nhacungcap]) VALUES (N'VX2', N'Vắc xin cúm K-New-H5 500ml ( 1000 liều )', 100, N'12000000', N'Thuốc', N'Thành phần: Mỗi liều sản phẩm có chứa: Newcastle disease (ND) chủng LaSota (rNDV/LS), và một đoạn gen được chèn vào của virus cúm AI Việt Nam, chủng H5 (rNDV/LS-AI/HA/H5), với hàm lượng tối thiểu 10^8.0 CEID50.
Liều dùng và hướng dẫn sử dụng: 0,5ml/con. Tiêm dưới da cổ hoặc tiêm cơ ức.
Chủng ngừa cho gà từ 1 ngày tuổi hoặc trễ hơn. Gà thịt: chủng vào 1 ngày tuổi trở lên. Vịt nuôi thịt, ngỗng và gà tây: chủng ngừa 2 lần, vào lúc 2 tuần tuổi và 40 ngày tuổi. Gà đẻ, giống trong giai đoạn hậu bị : chủng ngừa 3 lần, vào lúc 2, 8, và 16 tuần tuổi. Gia cầm trong chu trình sản xuất: Có thể chủng ngừa trong thời kỳ sản xuất, nếu cần. Gia cầm trong thời kỳ thay lông: Cần chủng nhắc lại ở cuối giai đoạn thay lông, khi trọng lượng cơ thể của gia cầm đã hồi phục. Lưu ý: Vaccine nên được làm ấm ở nhiệt độ phòng (25ºC -27ºC) trước khi chủng ngừa. Lắc đều trước khi sử dụng. Bảo quản: Bảo quản ở nhiệt độ 2 – 8 oC. Quy cách sản phẩm: 100ml, 250ml, 500ml. Nhà sản xuất: Laboratorio Avi-mex, Mexico.', N'TT phân phối thuốc trang trại FARMVET')
GO
INSERT [dbo].[taikhoan] ([tennguoidung], [matkhau], [email], [sodienthoai], [ngaysinh], [ngaydangky]) VALUES (N'admin', N'admin', NULL, NULL, NULL, NULL)
INSERT [dbo].[taikhoan] ([tennguoidung], [matkhau], [email], [sodienthoai], [ngaysinh], [ngaydangky]) VALUES (N'monxeko', N'monxeko', N'monxeko@gmail.com', N'0986404914', CAST(N'2004-06-02' AS Date), CAST(N'2023-10-30' AS Date))
INSERT [dbo].[taikhoan] ([tennguoidung], [matkhau], [email], [sodienthoai], [ngaysinh], [ngaydangky]) VALUES (N'user', N'user', NULL, NULL, NULL, NULL)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_tennhacungcap]    Script Date: 03/01/2024 11:16:46 CH ******/
ALTER TABLE [dbo].[nhacungcap] ADD  CONSTRAINT [UQ_tennhacungcap] UNIQUE NONCLUSTERED 
(
	[tennhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[hoadon]  WITH CHECK ADD  CONSTRAINT [FK_hoadon_tennguoidung] FOREIGN KEY([tennguoidung])
REFERENCES [dbo].[taikhoan] ([tennguoidung])
GO
ALTER TABLE [dbo].[hoadon] CHECK CONSTRAINT [FK_hoadon_tennguoidung]
GO
ALTER TABLE [dbo].[hoadonnhap]  WITH NOCHECK ADD  CONSTRAINT [FK_hoadonnhap_masanpham] FOREIGN KEY([masanpham])
REFERENCES [dbo].[sanpham] ([masanpham])
GO
ALTER TABLE [dbo].[hoadonnhap] NOCHECK CONSTRAINT [FK_hoadonnhap_masanpham]
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_Sanpham_Nhacungcap] FOREIGN KEY([nhacungcap])
REFERENCES [dbo].[nhacungcap] ([tennhacungcap])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_Sanpham_Nhacungcap]
GO
/****** Object:  StoredProcedure [dbo].[hoadonnguoidung]    Script Date: 03/01/2024 11:16:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[hoadonnguoidung]
@tennguoidung nvarchar(25)
AS
begin
select * from hoadon where hoadon.tennguoidung = @tennguoidung
END
GO
