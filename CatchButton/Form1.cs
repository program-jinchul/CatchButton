using System.Media;
using static System.Net.Mime.MediaTypeNames;
namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 3-0 점수변수선언
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 3-1 점수증가(100점씩)
            score += 100;
            // 2-1. 소리재생( System.Media.SystemSounds.Beep.Play() )
            System.Media.SystemSounds.Beep.Play();
            // 3-2. 점수업데이트(폼제목표시줄에점수출력) 여기에는 아래처럼 nextX, nextY 같은 변수의 입력이 없어서
            // 대신 버튼의 현재 위치를 직접 참조하여 표시하도록 수정
            this.Text = $"점수 : {score} | 버튼위치 : ({jcButton.Left}, {jcButton.Top})";
            // 2-2 잡았을 때 메세지 박스 메서드(messagebox.show)
            MessageBox.Show("🎉 축하합니다! 버튼을 잡았습니다!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // 3-3 점수감소(10점씩)
            score -= 10;
            // 2-3 놓쳤을 때 소리재생( System.Media.SystemSounds.Asterisk.Play() )
            System.Media.SystemSounds.Asterisk.Play();
            // 1. 난수생성기준비
            Random rd= new Random();
            // 2. 가용영역계산(버튼이폼테두리에걸리지않게보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            //수정: 버튼이 화면 밖으로 나가지 않게 버튼 크기만큼 여유를 제외한 최대 좌표 계산
            int maxX = Math.Max(0, ClientSize.Width - jcButton.Width); int maxY = Math.Max(0, ClientSize.Height - jcButton.Height);
            // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
            int nextX= rd.Next(0, maxX+1);int nextY= rd.Next(0, maxY+1);
            // 4. 위치할당(새로운Point 객체생성)
            jcButton.Location= new Point(nextX, nextY);
            // 5. 시각적피드백(폼제목표시줄에좌표출력)
            // 3-4 점수업데이트(폼제목표시줄에점수출력) 여기에는 위에처럼 변수가 없는게 아니어서 이용해서 작성
            this.Text = $"점수 : {score} | 버튼위치 : ({nextX}, {nextY})";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
