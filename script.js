// Xử lý sự kiện khi trang được tải
document.addEventListener('DOMContentLoaded', function() {
    // Khởi tạo tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    // Xử lý chuyển đổi trang
    const navLinks = document.querySelectorAll('.nav-link');
    navLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            navLinks.forEach(l => l.classList.remove('active'));
            this.classList.add('active');
        });
    });

    // Xử lý form lọc
    const filterForm = document.getElementById('filterForm');
    if (filterForm) {
        filterForm.addEventListener('submit', function(e) {
            e.preventDefault();
            // Xử lý lọc dữ liệu
            const formData = new FormData(filterForm);
            console.log('Filter data:', Object.fromEntries(formData));
            // TODO: Gọi API lọc dữ liệu
        });
    }

    // Xử lý tìm kiếm
    const searchInput = document.querySelector('.search-input');
    if (searchInput) {
        searchInput.addEventListener('keyup', function() {
            searchItems(this.value);
        });
    }

    // Xử lý phân trang
    const paginationLinks = document.querySelectorAll('.pagination .page-link');
    paginationLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            // TODO: Xử lý phân trang
            console.log('Page clicked:', this.textContent);
        });
    });

    // Xử lý các nút thao tác
    document.querySelectorAll('.btn-info').forEach(btn => {
        btn.addEventListener('click', function() {
            const id = this.getAttribute('data-id');
            showDetails(id);
        });
    });

    document.querySelectorAll('.btn-warning').forEach(btn => {
        btn.addEventListener('click', function() {
            const id = this.getAttribute('data-id');
            editItem(id);
        });
    });

    document.querySelectorAll('.btn-danger').forEach(btn => {
        btn.addEventListener('click', function() {
            const id = this.getAttribute('data-id');
            deleteItem(id);
        });
    });

    // Xử lý form thêm mới
    const addForm = document.getElementById('addForm');
    if (addForm) {
        addForm.addEventListener('submit', function(e) {
            e.preventDefault();
            addNewItem(this);
        });
    }

    // Khởi tạo các biểu đồ thống kê
    initializeCharts();

    // Cập nhật thống kê khi trang được tải
    updateStats();
});

// Hàm chuyển đổi trang
function switchPage(page) {
    // Ẩn tất cả các trang
    document.querySelectorAll('[id$="-page"]').forEach(p => p.style.display = 'none');
    
    // Hiển thị trang được chọn
    const selectedPage = document.getElementById(page + '-page');
    if (selectedPage) {
        selectedPage.style.display = 'block';
    }

    // Cập nhật trạng thái active của menu
    document.querySelectorAll('.nav-link').forEach(link => {
        link.classList.remove('active');
        if (link.getAttribute('data-page') === page) {
            link.classList.add('active');
        }
    });
}

// Hàm hiển thị chi tiết
function showDetails(id) {
    // TODO: Implement show details logic
    console.log('Show details for ID:', id);
}

// Hàm chỉnh sửa
function editItem(id) {
    // TODO: Implement edit logic
    console.log('Edit item with ID:', id);
}

// Hàm xóa
function deleteItem(id) {
    if (confirm('Bạn có chắc chắn muốn xóa mục này?')) {
        // TODO: Implement delete logic
        console.log('Delete item with ID:', id);
    }
}

// Hàm thêm mới
function addNewItem(form) {
    const formData = new FormData(form);
    const data = Object.fromEntries(formData.entries());
    // TODO: Implement add new item logic
    console.log('Add new item:', data);
}

// Hàm tìm kiếm
function searchItems(query) {
    const rows = document.querySelectorAll('tbody tr');
    rows.forEach(row => {
        const text = row.textContent.toLowerCase();
        row.style.display = text.includes(query.toLowerCase()) ? '' : 'none';
    });
}

// Hàm cập nhật thống kê
function updateStats() {
    // TODO: Implement stats update logic
    console.log('Updating statistics...');
}

// Hàm format tiền tệ
function formatCurrency(amount) {
    return new Intl.NumberFormat('vi-VN', {
        style: 'currency',
        currency: 'VND'
    }).format(amount);
}

// Hàm khởi tạo biểu đồ
function initializeCharts() {
    // TODO: Implement charts using Chart.js or similar library
    console.log('Khởi tạo biểu đồ thống kê');
}

// Cập nhật thống kê mỗi 5 phút
setInterval(updateStats, 300000); 